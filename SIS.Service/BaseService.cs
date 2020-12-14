﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Service
{
    public abstract class BaseService
    {
        public virtual TDestination Map<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }
        public virtual TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        public void SetLog<S, T>(S entity, T model, Entity.Entities.SISDbContext db, int RecId)
        {
            //string tableName = entity.GetType().CustomAttributes.Count() == 0 ? entity.GetType().BaseType.Name : entity.GetType().Name;
            //var diffirences = new FBLOGDTO();
            //Type entiType = entity.GetType();
            //Type modelType = model.GetType();
            //var tableId = (dynamic)null;
            //var modelPropertys = modelType.GetProperties();
            //var properties = entiType.GetProperties();
            //foreach (var item in properties)
            //{

            //    var targetProperty = modelType.GetProperty(item.Name);
            //    if (targetProperty != null && item.PropertyType.Equals(targetProperty.PropertyType))
            //    {
            //        if (item.PropertyType.IsGenericType && !item.PropertyType.IsValueType)
            //        {
            //            continue;
            //        }

            //        object oldValue = item.GetValue(entity, null);
            //        object newValue = item.GetValue(Map<T, S>(model), null);
            //        if (oldValue == null && newValue == null)
            //        {
            //            continue;
            //        }
            //        if (oldValue != null && newValue != null)
            //        {
            //            if (oldValue.ToString().Length > 50)
            //            {
            //                oldValue = oldValue.ToString().Substring(0, 50);
            //            }
            //            if (newValue.ToString().Length > 50)
            //            {
            //                newValue = newValue.ToString().Substring(0, 50);
            //            }
            //        }


            //        if (oldValue != null && newValue != null && !oldValue.Equals(newValue))
            //        {
            //            if (tableId == null)
            //            {
            //                for (int k = 0; k < properties.Length; k++)
            //                {
            //                    if (properties[k].Name == "RecId")
            //                    {
            //                        tableId = properties[k].GetValue(entity, null);
            //                    }
            //                }
            //            }
            //            diffirences.UserCode = Global.User.UserCode;
            //            diffirences.CompanyCode = "";// Global.Company.CompanyCode;
            //            diffirences.HotelDate = DateTime.Today;
            //            diffirences.FieldName = item.Name;
            //            diffirences.TableName = tableName;
            //            diffirences.Old = oldValue.ToString();
            //            diffirences.New = newValue.ToString();
            //            diffirences.ADateTime = DateTime.Now;
            //            diffirences.TableId = tableId;
            //            diffirences.AType = 0;
            //            diffirences.PCName = Environment.MachineName.ToString();
            //            diffirences.FormName = FormName;
            //            diffirences.MasterId = RecId;
            //            diffirences.CompanyRecId = 0;// Global.Company.RecId;
            //            db.FBLOGs.Add(Map<FBLOGDTO, FBLOG>(diffirences));
            //        }
            //    }
            //}

        }
    }
}
