using SIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SIS.Service.Admin;
using SIS.Service.Admin.Http;
using SIS.Service.Extensions;
using SIS.Data.App;
using SIS.Service.RouteMap;

namespace SIS.Service.Admin
{
    public class Repository
    {
        private HttpService _httpService;
        private bool __RunningLocal;
        public Repository(bool _RunningLocal, string _ApiUrl)
        {
            __RunningLocal = _RunningLocal;
            if (_ApiUrl != "")
            {
                _httpService = new HttpService(_ApiUrl);
            }
        }



        public G Run<T, G>(Expression<Func<T, G>> expression) where T : BaseService where G : class
        {
            var instance = Activator.CreateInstance<T>();

            if (__RunningLocal)
            {
                var action = expression.Compile();

                return action(instance);
            }
            else
            {
                //string controllerName = ReflectionHelper.GetProperty(instance, "").ToString();

                string controllerName = ReflectionHelper.GetProperty(instance, "ControllerName").ToString();
                string actionName = ((MethodCallExpression)expression.Body).Method.Name;
                //RouteMapDTO route = new RouteMapDTO
                //{
                //    Name = controllerName,
                //    Route = $"{controllerName}/{actionName}"
                //};

                //    _httpService.SetRoute(route);
                // _httpService.SetRouteMap(((MethodCallExpression)expression.Body).Method.Name);
                var parameterList = instance.GetType().GetMethod(actionName).GetParameters().Select(c => c.Name).ToList();

                var attr = instance.GetType().GetMember(actionName).FirstOrDefault().GetCustomAttribute(typeof(HttpAction), true) as HttpAction;


                RouteMapDTO route = new RouteMapDTO
                {
                    Name = controllerName,
                    Route = $"{controllerName}/{actionName}",
                    HttpMethod = attr.HttpMethod
                };
                _httpService.SetRoute(route);

                var objects = expression.GetParamsFromExpression();
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                for (int i = 0; i < parameterList.Count; i++)
                {
                    dictionary.Add(parameterList[i], objects[i]);
                }

                return _httpService.Send<G>(dictionary);
            }
        }

        public async Task<G> RunAsync<T, G>(Expression<Func<T, G>> expression) where T : BaseService where G : class
        {
            var instance = Activator.CreateInstance<T>();

            if (__RunningLocal)
            {
                var action = expression.Compile();

                return action(instance);
            }
            else
            {
                //string controllerName = ReflectionHelper.GetProperty(instance, "").ToString();

                string controllerName = ReflectionHelper.GetProperty(instance, "ControllerName").ToString();
                string actionName = ((MethodCallExpression)expression.Body).Method.Name;
                //RouteMapDTO route = new RouteMapDTO
                //{
                //    Name = controllerName,
                //    Route = $"{controllerName}/{actionName}"
                //};

                //    _httpService.SetRoute(route);
                // _httpService.SetRouteMap(((MethodCallExpression)expression.Body).Method.Name);
                var parameterList = instance.GetType().GetMethod(actionName).GetParameters().Select(c => c.Name).ToList();

                var attr = instance.GetType().GetMember(actionName).FirstOrDefault().GetCustomAttribute(typeof(HttpAction), true) as HttpAction;


                RouteMapDTO route = new RouteMapDTO
                {
                    Name = controllerName,
                    Route = $"{controllerName}/{actionName}",
                    HttpMethod = attr.HttpMethod
                };
                _httpService.SetRoute(route);

                var objects = expression.GetParamsFromExpression();
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                for (int i = 0; i < parameterList.Count; i++)
                {
                    dictionary.Add(parameterList[i], objects[i]);
                }

                return _httpService.Send<G>(dictionary);
            }
        }



        public G get_KodAdmin<T, G>(Expression<Func<T, G>> expression) where T : BaseService where G : class
        {
            var instance = Activator.CreateInstance<T>();




            string controllerName = ReflectionHelper.GetProperty(instance, "ControllerName").ToString();
            string actionName = ((MethodCallExpression)expression.Body).Method.Name;

            var parameterList = instance.GetType().GetMethod(actionName).GetParameters().Select(c => c.Name).ToList();

            var attr = instance.GetType().GetMember(actionName).FirstOrDefault().GetCustomAttribute(typeof(HttpAction), true) as HttpAction;


            RouteMapDTO route = new RouteMapDTO
            {
                Name = controllerName,
                Route = $"{controllerName}/{actionName}",
                HttpMethod = attr.HttpMethod
            };
            _httpService.SetRoute(route);

            var objects = expression.GetParamsFromExpression();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            for (int i = 0; i < parameterList.Count; i++)
            {
                dictionary.Add(parameterList[i], objects[i]);
            }

            return _httpService.Send<G>(dictionary);

        }


    }
}
