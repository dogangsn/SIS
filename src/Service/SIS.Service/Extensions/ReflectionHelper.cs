using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace SIS.Service.Extensions
{
    /// <summary>
    /// Collection of Reflection and type conversion related utility functions
    /// </summary>
    public static class ReflectionHelper
    {

        /// <summary>
        /// Binding Flags constant to be reused for all Reflection access methods.
        /// </summary>
        public const BindingFlags MemberAccess =
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase;


        /// <summary>
        /// Retrieve a property value from an object dynamically. This is a simple version
        /// that uses Reflection calls directly. It doesn't support indexers.
        /// </summary>
        /// <param name="instance">Object to make the call on</param>
        /// <param name="property">Property to retrieve</param>
        /// <returns>Object - cast to proper type</returns>
        public static object GetProperty(object instance, string property)
        {
            return instance.GetType().GetProperty(property, ReflectionHelper.MemberAccess).GetValue(instance, null);
        }

        /// <summary>
        /// Retrieve a field dynamically from an object. This is a simple implementation that's
        /// straight Reflection and doesn't support indexers.
        /// </summary>
        /// <param name="Object">Object to retreve Field from</param>
        /// <param name="Property">name of the field to retrieve</param>
        /// <returns></returns>
        public static object GetField(object Object, string Property)
        {
            return Object.GetType().GetField(Property, ReflectionHelper.MemberAccess).GetValue(Object);
        }

        /// <summary>
        /// Parses Properties and Fields including Array and Collection references.
        /// Used internally for the 'Ex' Reflection methods.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        private static object GetPropertyInternal(object parent, string property)
        {
            if (property == "this" || property == "me")
                return parent;

            object result = null;
            string pureProperty = property;
            string indexes = null;
            bool isArrayOrCollection = false;

            // Deal with Array Property
            if (property.IndexOf("[", System.StringComparison.Ordinal) > -1)
            {
                pureProperty = property.Substring(0, property.IndexOf("[", System.StringComparison.Ordinal));
                indexes = property.Substring(property.IndexOf("[", System.StringComparison.Ordinal));
                isArrayOrCollection = true;
            }

            // Get the member
            var member = parent.GetType().GetMember(pureProperty, ReflectionHelper.MemberAccess)[0];
            if (member.MemberType == MemberTypes.Property)
                result = ((PropertyInfo)member).GetValue(parent, null);
            else
                result = ((FieldInfo)member).GetValue(parent);

            if (isArrayOrCollection)
            {
                indexes = indexes.Replace("[", string.Empty).Replace("]", string.Empty);

                if (result is Array)
                {
                    var index = -1;
                    int.TryParse(indexes, out index);
                    result = CallMethod(result, "GetValue", index);
                }
                else if (result is ICollection)
                {
                    if (indexes.StartsWith("\""))
                    {
                        // String Index
                        indexes = indexes.Trim('\"');
                        result = CallMethod(result, "get_Item", indexes);
                    }
                    else
                    {
                        // assume numeric index
                        int index = -1;
                        int.TryParse(indexes, out index);
                        result = CallMethod(result, "get_Item", index);
                    }
                }

            }

            return result;
        }


        /// <summary>
        /// Parses Properties and Fields including Array and Collection references.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static object SetPropertyInternal(object parent, string property, object value)
        {
            if (property == "this" || property == "me")
                return parent;

            object result = null;
            string pureProperty = property;
            string indexes = null;
            bool isArrayOrCollection = false;

            // Deal with Array Property
            if (property.IndexOf("[", System.StringComparison.Ordinal) > -1)
            {
                pureProperty = property.Substring(0, property.IndexOf("[", System.StringComparison.Ordinal));
                indexes = property.Substring(property.IndexOf("[", System.StringComparison.Ordinal));
                isArrayOrCollection = true;
            }

            if (!isArrayOrCollection)
            {
                // Get the member
                var member = parent.GetType().GetMember(pureProperty, ReflectionHelper.MemberAccess)[0];
                if (member.MemberType == MemberTypes.Property)
                    ((PropertyInfo)member).SetValue(parent, value, null);
                else
                    ((FieldInfo)member).SetValue(parent, value);
                return null;
            }
            else
            {
                // Get the member
                var member = parent.GetType().GetMember(pureProperty, ReflectionHelper.MemberAccess)[0];
                if (member.MemberType == MemberTypes.Property)
                    result = ((PropertyInfo)member).GetValue(parent, null);
                else
                    result = ((FieldInfo)member).GetValue(parent);
            }
            if (isArrayOrCollection)
            {
                indexes = indexes.Replace("[", string.Empty).Replace("]", string.Empty);

                if (result is Array)
                {
                    int index = -1;
                    int.TryParse(indexes, out index);
                    result = CallMethod(result, "SetValue", value, index);
                }
                else if (result is ICollection)
                {
                    if (indexes.StartsWith("\""))
                    {
                        // String Index
                        indexes = indexes.Trim('\"');
                        result = CallMethod(result, "set_Item", indexes, value);
                    }
                    else
                    {
                        // assume numeric index
                        var index = -1;
                        int.TryParse(indexes, out index);
                        result = CallMethod(result, "set_Item", index, value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a property or field value using a base object and sub members including . syntax.
        /// For example, you can access: oCustomer.oData.Company with (this,"oCustomer.oData.Company")
        /// This method also supports indexers in the Property value such as:
        /// Customer.DataSet.Tables["Customers"].Rows[0]
        /// </summary>
        /// <param name="parent">Parent object to 'start' parsing from. Typically this will be the Page.</param>
        /// <param name="property">The property to retrieve. Example: 'Customer.Entity.Company'</param>
        /// <returns></returns>
        public static object GetPropertyEx(object parent, string property)
        {
            Type type = parent.GetType();

            int at = property.IndexOf(".", System.StringComparison.Ordinal);
            if (at < 0)
            {
                // Complex parse of the property    
                return GetPropertyInternal(parent, property);
            }

            // Walk the . syntax - split into current object (Main) and further parsed objects (Subs)
            string main = property.Substring(0, at);
            string subs = property.Substring(at + 1);

            // Retrieve the next . section of the property
            object sub = GetPropertyInternal(parent, main);

            // Now go parse the left over sections
            return GetPropertyEx(sub, subs);
        }

        /// <summary>
        /// Returns a PropertyInfo object for a given dynamically accessed property
        /// 
        /// Property selection can be specified using . syntax ("Address.Street" or "DataTable[0].Rows[1]") hence the <<i>>Ex<</i>> name for this function.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static PropertyInfo GetPropertyInfoEx(object parent, string property)
        {
            var type = parent.GetType();

            var at = property.IndexOf(".", System.StringComparison.Ordinal);
            if (at < 0)
            {
                // Complex parse of the property    
                return GetPropertyInfoInternal(parent, property);
            }

            // Walk the . syntax - split into current object (Main) and further parsed objects (Subs)
            var main = property.Substring(0, at);
            var subs = property.Substring(at + 1);

            // Retrieve the next . section of the property
            var sub = GetPropertyInternal(parent, main);

            // Now go parse the left over sections
            return GetPropertyInfoEx(sub, subs);
        }

        /// <summary>
        /// Returns a PropertyInfo structure from an extended Property reference
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static PropertyInfo GetPropertyInfoInternal(object parent, string property)
        {
            if (property == "this" || property == "me")
                return null;

            string propertyName = property;

            // Deal with Array Property - strip off array indexer
            if (property.IndexOf("[", System.StringComparison.Ordinal) > -1)
                propertyName = property.Substring(0, property.IndexOf("[", System.StringComparison.Ordinal));

            // Get the member
            return parent.GetType().GetProperty(propertyName, ReflectionHelper.MemberAccess);
        }

        /// <summary>
        /// Sets the property on an object. This is a simple method that uses straight Reflection 
        /// and doesn't support indexers.
        /// </summary>
        /// <param name="obj">Object to set property on</param>
        /// <param name="property">Name of the property to set</param>
        /// <param name="value">value to set it to</param>
        public static void SetProperty(object obj, string property, object value)
        {
            obj.GetType().GetProperty(property, ReflectionHelper.MemberAccess).SetValue(obj, value, null);
        }

        /// <summary>
        /// Sets the field on an object. This is a simple method that uses straight Reflection 
        /// and doesn't support indexers.
        /// </summary>
        /// <param name="obj">Object to set property on</param>
        /// <param name="property">Name of the field to set</param>
        /// <param name="value">value to set it to</param>
        public static void SetField(object obj, string property, object value)
        {
            obj.GetType().GetField(property, ReflectionHelper.MemberAccess).SetValue(obj, value);
        }

        /// <summary>
        /// Sets a value on an object. Supports . syntax for named properties
        /// (ie. Customer.Entity.Company) as well as indexers.
        /// </summary>
        /// <param name="Object Parent">
        /// Object to set the property on.
        /// </param>
        /// <param name="String Property">
        /// Property to set. Can be an object hierarchy with . syntax and can 
        /// include indexers. Examples: Customer.Entity.Company, 
        /// Customer.DataSet.Tables["Customers"].Rows[0]
        /// </param>
        /// <param name="Object Value">
        /// Value to set the property to
        /// </param>
        public static object SetPropertyEx(object parent, string property, object value)
        {
            Type Type = parent.GetType();

            // no more .s - we got our final object
            int lnAt = property.IndexOf(".", System.StringComparison.Ordinal);
            if (lnAt < 0)
            {
                SetPropertyInternal(parent, property, value);
                return null;
            }

            // Walk the . syntax
            var main = property.Substring(0, lnAt);
            var subs = property.Substring(lnAt + 1);

            var sub = GetPropertyInternal(parent, main);

            SetPropertyEx(sub, subs, value);

            return null;
        }

        /// <summary>
        /// Calls a method on an object dynamically. This version requires explicit
        /// specification of the parameter type signatures.
        /// </summary>
        /// <param name="instance">Instance of object to call method on</param>
        /// <param name="method">The method to call as a stringToTypedValue</param>
        /// <param name="parameterTypes">Specify each of the types for each parameter passed. 
        /// You can also pass null, but you may get errors for ambiguous methods signatures
        /// when null parameters are passed</param>
        /// <param name="parms">any variable number of parameters.</param>        
        /// <returns>object</returns>
        public static object CallMethod(object instance, string method, Type[] parameterTypes, params object[] parms)
        {
            if (parameterTypes == null && parms.Length > 0)
                // Call without explicit parameter types - might cause problems with overloads    
                // occurs when null parameters were passed and we couldn't figure out the parm type
                return instance.GetType().GetMethod(method, ReflectionHelper.MemberAccess | BindingFlags.InvokeMethod).Invoke(instance, parms);
            else
                // Call with parameter types - works only if no null values were passed
                return instance.GetType().GetMethod(method, ReflectionHelper.MemberAccess | BindingFlags.InvokeMethod, null, parameterTypes, null).Invoke(instance, parms);
        }

        /// <summary>
        /// Calls a method on an object dynamically. 
        /// 
        /// This version doesn't require specific parameter signatures to be passed. 
        /// Instead parameter types are inferred based on types passed. Note that if 
        /// you pass a null parameter, type inferrance cannot occur and if overloads
        /// exist the call may fail. if so use the more detailed overload of this method.
        /// </summary> 
        /// <param name="instance">Instance of object to call method on</param>
        /// <param name="method">The method to call as a stringToTypedValue</param>
        /// <param name="parameterTypes">Specify each of the types for each parameter passed. 
        /// You can also pass null, but you may get errors for ambiguous methods signatures
        /// when null parameters are passed</param>
        /// <param name="parms">any variable number of parameters.</param>        
        /// <returns>object</returns>
        public static object CallMethod(object instance, string method, params object[] parms)
        {
            // Pick up parameter types so we can match the method properly
            Type[] parameterTypes = null;
            if (parms != null)
            {
                parameterTypes = new Type[parms.Length];
                for (int x = 0; x < parms.Length; x++)
                {
                    // if we have null parameters we can't determine parameter types - exit
                    if (parms[x] == null)
                    {
                        parameterTypes = null;  // clear out - don't use types        
                        break;
                    }
                    parameterTypes[x] = parms[x].GetType();
                }
            }
            return CallMethod(instance, method, parameterTypes, parms);
        }

        /// <summary>
        /// Calls a method on an object with extended . syntax (object: this Method: Entity.CalculateOrderTotal)
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="method"></param>
        /// <param name="params"></param>
        /// <returns></returns>
        public static object CallMethodEx(object parent, string method, params object[] parms)
        {
            Type Type = parent.GetType();

            // no more .s - we got our final object
            int lnAt = method.IndexOf(".", System.StringComparison.Ordinal);
            if (lnAt < 0)
            {
                return ReflectionHelper.CallMethod(parent, method, parms);
            }

            // Walk the . syntax
            var main = method.Substring(0, lnAt);
            var subs = method.Substring(lnAt + 1);

            var sub = GetPropertyInternal(parent, main);

            // Recurse until we get the lowest ref
            return CallMethodEx(sub, subs, parms);
        }




        /// <summary>
        /// Creates an instance from a type by calling the parameterless constructor.
        /// 
        /// Note this will not work with COM objects - continue to use the Activator.CreateInstance
        /// for COM objects.
        /// <seealso>Class wwUtils</seealso>
        /// </summary>
        /// <param name="typeToCreate">
        /// The type from which to create an instance.
        /// </param>
        /// <returns>object</returns>
        public static object CreateInstanceFromType(Type typeToCreate, params object[] args)
        {
            if (args == null)
            {
                Type[] Parms = Type.EmptyTypes;
                return typeToCreate.GetConstructor(Parms).Invoke(null);
            }

            return Activator.CreateInstance(typeToCreate, args);
        }




        /// <summary>
        /// Creates an instance of a type based on a string. Assumes that the type's
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object CreateInstanceFromString(string typeName, params object[] args)
        {
            object instance = null;
            Type type = null;

            try
            {
                type = GetTypeFromName(typeName);
                if (type == null)
                    return null;

                instance = Activator.CreateInstance(type, args);
            }
            catch
            {
                return null;
            }

            return instance;
        }

        /// <summary>
        /// Helper routine that looks up a type name and tries to retrieve the
        /// full type reference in the actively executing assemblies.
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static Type GetTypeFromName(string typeName)
        {
            Type type = null;

            type = Type.GetType(typeName, false);
            if (type != null)
                return type;

            // try to find manually
            foreach (Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = ass.GetType(typeName, false);

                if (type != null)
                    break;

            }
            return type;
        }


        /// <summary>
        /// Creates a COM instance from a ProgID. Loads either
        /// Exe or DLL servers.
        /// </summary>
        /// <param name="progId"></param>
        /// <returns></returns>
        public static object CreateComInstance(string progId)
        {
            Type type = Type.GetTypeFromProgID(progId);
            if (type == null)
                return null;

            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// Converts a type to string if possible. This method supports an optional culture generically on any value.
        /// It calls the ToString() method on common types and uses a type converter on all other objects
        /// if available
        /// </summary>
        /// <param name="rawValue">The Value or Object to convert to a string</param>
        /// <param name="culture">Culture for numeric and DateTime values</param>
        /// <returns>string</returns>
        public static string TypedValueToString(object rawValue, CultureInfo culture)
        {
            if (rawValue == null)
                return string.Empty;

            Type valueType = rawValue.GetType();
            string Return = null;

            if (valueType == typeof(string))
                Return = rawValue.ToString();
            else if (valueType == typeof(int) || valueType == typeof(decimal) ||
                valueType == typeof(double) || valueType == typeof(float))
                Return = string.Format(culture.NumberFormat, "{0}", rawValue);
            else if (valueType == typeof(DateTime))
                Return = string.Format(culture.DateTimeFormat, "{0}", rawValue);
            else if (valueType == typeof(bool))
                Return = rawValue.ToString();
            else if (valueType == typeof(byte))
                Return = rawValue.ToString();
            else if (valueType.IsEnum)
                Return = rawValue.ToString();
            else if (valueType == typeof(Guid?))
            {
                if (rawValue == null)
                    Return = string.Empty;
                else
                    return rawValue.ToString();
            }
            else
            {
                // Any type that supports a type converter
                TypeConverter converter = TypeDescriptor.GetConverter(valueType);
                if (converter != null && converter.CanConvertTo(typeof(string)))
                    Return = converter.ConvertToString(null, culture, rawValue);
                else
                    // Last resort - just call ToString() on unknown type
                    Return = rawValue.ToString();
            }

            return Return;
        }

        /// <summary>
        /// Converts a type to string if possible. This method uses the current culture for numeric and DateTime values.
        /// It calls the ToString() method on common types and uses a type converter on all other objects
        /// if available.
        /// </summary>
        /// <param name="rawValue">The Value or Object to convert to a string</param>
        /// <param name="Culture">Culture for numeric and DateTime values</param>
        /// <returns>string</returns>
        public static string TypedValueToString(object rawValue)
        {
            return TypedValueToString(rawValue, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Turns a string into a typed value generically.
        /// Explicitly assigns common types and falls back
        /// on using type converters for unhandled types.         
        /// 
        /// Common uses: 
        /// * UI -&gt; to data conversions
        /// * Parsers
        /// <seealso>Class ReflectionHelper</seealso>
        /// </summary>
        /// <param name="sourceString">
        /// The string to convert from
        /// </param>
        /// <param name="targetType">
        /// The type to convert to
        /// </param>
        /// <param name="culture">
        /// Culture used for numeric and datetime values.
        /// </param>
        /// <returns>object. Throws exception if it cannot be converted.</returns>
        public static object StringToTypedValue(string sourceString, Type targetType, CultureInfo culture)
        {
            object result = null;

            bool isEmpty = string.IsNullOrEmpty(sourceString);

            if (targetType == typeof(string))
                result = sourceString;
            else if (targetType == typeof(Int32) || targetType == typeof(int))
            {
                if (isEmpty)
                    result = 0;
                else
                    result = Int32.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(Int64))
            {
                if (isEmpty)
                    result = (Int64)0;
                else
                    result = Int64.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(Int16))
            {
                if (isEmpty)
                    result = (Int16)0;
                else
                    result = Int16.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(decimal))
            {
                if (isEmpty)
                    result = 0M;
                else
                    result = decimal.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(DateTime))
            {
                if (isEmpty)
                    result = DateTime.MinValue;
                else
                    result = Convert.ToDateTime(sourceString, culture.DateTimeFormat);
            }
            else if (targetType == typeof(byte))
            {
                if (isEmpty)
                    result = 0;
                else
                    result = Convert.ToByte(sourceString);
            }
            else if (targetType == typeof(double))
            {
                if (isEmpty)
                    result = 0F;
                else
                    result = Double.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(Single))
            {
                if (isEmpty)
                    result = 0F;
                else
                    result = Single.Parse(sourceString, NumberStyles.Any, culture.NumberFormat);
            }
            else if (targetType == typeof(bool))
            {
                if (!isEmpty &&
                    sourceString.ToLower() == "true" || sourceString.ToLower() == "on" || sourceString == "1")
                    result = true;
                else
                    result = false;
            }
            else if (targetType == typeof(Guid))
            {
                if (isEmpty)
                    result = Guid.Empty;
                else
                    result = new Guid(sourceString);
            }
            else if (targetType.IsEnum)
                result = Enum.Parse(targetType, sourceString);
            else if (targetType == typeof(byte[]))
            {
                // UNDONE: Convert HexBinary string to byte array
                result = null;
            }
            // Handle nullables explicitly since type converter won't handle conversions
            // properly for things like decimal separators currency formats etc.
            // Grab underlying type and pass value to that
            else if (targetType.Name.StartsWith("Nullable`"))
            {
                if (sourceString.ToLower() == "null" || sourceString == string.Empty)
                    result = null;
                else
                {
                    targetType = Nullable.GetUnderlyingType(targetType);
                    result = StringToTypedValue(sourceString, targetType);
                }
            }
            else
            {
                TypeConverter converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null && converter.CanConvertFrom(typeof(string)))
                    result = converter.ConvertFromString(null, culture, sourceString);
                else
                {
                    Debug.Assert(false, string.Format("Type Conversion not handled in StringToTypedValue for {0} {1}",
                                                      targetType.Name, sourceString));
                    //throw (new InvalidCastException(Resources.StringToTypedValueValueTypeConversionFailed + targetType.Name));
                    throw (new InvalidCastException(string.Format("Type Conversion not handled in StringToTypedValue for {0} {1}",
                                                      targetType.Name, sourceString)));
                }
            }

            return result;
        }

        /// <summary>
        /// Turns a string into a typed value generically.
        /// Explicitly assigns common types and falls back
        /// on using type converters for unhandled types.         
        /// 
        /// Common uses: 
        /// * UI -&gt; to data conversions
        /// * Parsers
        /// <seealso>Class ReflectionHelper</seealso>
        /// </summary>
        /// <param name="sourceString">
        /// The string to convert from
        /// </param>
        /// <param name="targetType">
        /// The type to convert to
        /// </param>
        /// <returns>object. Throws exception if it cannot be converted.</returns>
        public static object StringToTypedValue(string sourceString, Type targetType)
        {
            return StringToTypedValue(sourceString, targetType, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Generic version allow for automatic type conversion without the explicit type
        /// parameter
        /// </summary>
        /// <typeparam name="T">Type to be converted to</typeparam>
        /// <param name="sourceString">input string value to be converted</param>
        /// <param name="culture">Culture applied to conversion</param>
        /// <returns></returns>
        public static T StringToTypedValue<T>(string sourceString, CultureInfo culture)
        {
            return (T)StringToTypedValue(sourceString, typeof(T), culture);
        }

        /// <summary>
        /// Generic version allow for automatic type conversion without the explicit type
        /// parameter. Defaults conversion to CurrentCulture.
        /// </summary>
        /// <typeparam name="T">Type to be converted to</typeparam>
        /// <param name="sourceString">input string value to be converted</param>
        /// <returns></returns>
        public static T StringToTypedValue<T>(string sourceString)
        {
            return (T)StringToTypedValue(sourceString, typeof(T), CultureInfo.CurrentCulture);
        }

   

        /// <summary>
        /// Retrieves a value from  a static property by specifying a type full name and property
        /// </summary>
        /// <param name="typeName">Full type name (namespace.class)</param>
        /// <param name="property">Property to get value from</param>
        /// <returns></returns>
        public static object GetStaticProperty(string typeName, string property)
        {
            Type type = GetTypeFromName(typeName);
            if (type == null)
                return null;

            return GetStaticProperty(type, property);
        }

        /// <summary>
        /// Returns a static property from a given type
        /// </summary>
        /// <param name="type">Type instance for the static property</param>
        /// <param name="property">Property name as a string</param>
        /// <returns></returns>
        public static object GetStaticProperty(Type type, string property)
        {
            object result = null;
            try
            {
                result = type.InvokeMember(property, BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField | BindingFlags.GetProperty, null, type, null);
            }
            catch
            {
                return null;
            }

            return result;
        }

        #region COM Reflection Routines

        /// <summary>
        /// Retrieve a dynamic 'non-typelib' property
        /// </summary>
        /// <param name="instance">Object to make the call on</param>
        /// <param name="property">Property to retrieve</param>
        /// <returns></returns>
        public static object GetPropertyCom(object instance, string property)
        {
            return instance.GetType().InvokeMember(property, ReflectionHelper.MemberAccess | BindingFlags.GetProperty | BindingFlags.GetField, null,
                                                instance, null);
        }


        /// <summary>
        /// Returns a property or field value using a base object and sub members including . syntax.
        /// For example, you can access: oCustomer.oData.Company with (this,"oCustomer.oData.Company")
        /// </summary>
        /// <param name="parent">Parent object to 'start' parsing from.</param>
        /// <param name="property">The property to retrieve. Example: 'oBus.oData.Company'</param>
        /// <returns></returns>
        public static object GetPropertyExCom(object parent, string property)
        {

            var type = parent.GetType();

            int lnAt = property.IndexOf(".", System.StringComparison.Ordinal);
            if (lnAt < 0)
            {
                if (property == "this" || property == "me")
                    return parent;

                // Get the member
                return parent.GetType().InvokeMember(property, ReflectionHelper.MemberAccess | BindingFlags.GetProperty | BindingFlags.GetField, null,
                    parent, null);
            }

            // Walk the . syntax - split into current object (Main) and further parsed objects (Subs)
            string main = property.Substring(0, lnAt);
            string subs = property.Substring(lnAt + 1);

            object sub = parent.GetType().InvokeMember(main, ReflectionHelper.MemberAccess | BindingFlags.GetProperty | BindingFlags.GetField, null,
                parent, null);

            // Recurse further into the sub-properties (Subs)
            return ReflectionHelper.GetPropertyExCom(sub, subs);
        }

        /// <summary>
        /// Sets the property on an object.
        /// </summary>
        /// <param name="Object">Object to set property on</param>
        /// <param name="property">Name of the property to set</param>
        /// <param name="Value">value to set it to</param>
        public static void SetPropertyCom(object Object, string property, object Value)
        {
            Object.GetType().InvokeMember(property, ReflectionHelper.MemberAccess | BindingFlags.SetProperty | BindingFlags.SetField, null, Object, new object[1] { Value });
        }

        /// <summary>
        /// Sets the value of a field or property via Reflection. This method alws 
        /// for using '.' syntax to specify objects multiple levels down.
        /// 
        /// ReflectionHelper.SetPropertyEx(this,"Invoice.LineItemsCount",10)
        /// 
        /// which would be equivalent of:
        /// 
        /// Invoice.LineItemsCount = 10;
        /// </summary>
        /// <param name="Object Parent">
        /// Object to set the property on.
        /// </param>
        /// <param name="String Property">
        /// Property to set. Can be an object hierarchy with . syntax.
        /// </param>
        /// <param name="Object Value">
        /// Value to set the property to
        /// </param>
        public static object SetPropertyExCom(object parent, string property, object value)
        {
            Type Type = parent.GetType();

            int lnAt = property.IndexOf(".");
            if (lnAt < 0)
            {
                // Set the member
                parent.GetType().InvokeMember(property, ReflectionHelper.MemberAccess | BindingFlags.SetProperty | BindingFlags.SetField, null,
                    parent, new object[1] { value });

                return null;
            }

            // Walk the . syntax - split into current object (Main) and further parsed objects (Subs)
            string Main = property.Substring(0, lnAt);
            string Subs = property.Substring(lnAt + 1);


            object Sub = parent.GetType().InvokeMember(Main, ReflectionHelper.MemberAccess | BindingFlags.GetProperty | BindingFlags.GetField, null,
                parent, null);

            return SetPropertyExCom(Sub, Subs, value);
        }


        /// <summary>
        /// Wrapper method to call a 'dynamic' (non-typelib) method
        /// on a COM object
        /// </summary>
        /// <param name="params"></param>
        /// 1st - Method name, 2nd - 1st parameter, 3rd - 2nd parm etc.
        /// <returns></returns>
        public static object CallMethodCom(object instance, string method, params object[] parms)
        {
            return instance.GetType().InvokeMember(method, ReflectionHelper.MemberAccess | BindingFlags.InvokeMethod, null, instance, parms);
        }

        /// <summary>
        /// Calls a method on a COM object with '.' syntax (Customer instance and Address.DoSomeThing method)
        /// </summary>
        /// <param name="parent">the object instance on which to call method</param>
        /// <param name="method">The method or . syntax path to the method (Address.Parse)</param>
        /// <param name="parms">Any number of parameters</param>
        /// <returns></returns>
        public static object CallMethodExCom(object parent, string method, params object[] parms)
        {
            Type Type = parent.GetType();

            // no more .s - we got our final object
            int at = method.IndexOf(".");
            if (at < 0)
            {
                return ReflectionHelper.CallMethod(parent, method, parms);
            }

            // Walk the . syntax - split into current object (Main) and further parsed objects (Subs)
            string Main = method.Substring(0, at);
            string Subs = method.Substring(at + 1);

            object Sub = parent.GetType().InvokeMember(Main, ReflectionHelper.MemberAccess | BindingFlags.GetProperty | BindingFlags.GetField, null,
                parent, null);

            // Recurse until we get the lowest ref
            return CallMethodEx(Sub, Subs, parms);
        }
        #endregion
        public static Dictionary<string, object> objectToDictionary<T>(T source)
        {
            Dictionary<string, object> oDictionary = new Dictionary<string, object>();
            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                if (info.CanRead && info.CanWrite)
                {
                    object obj2 = info.GetValue(source, null);
                    oDictionary.Add(info.Name, obj2);
                }
            }
            return oDictionary;
        }
    }
}
