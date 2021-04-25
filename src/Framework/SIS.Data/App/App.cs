using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.App
{
    public class App
    {

    }

    public class AppIdView
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string app;

        public string App
        {
            get { return app; }
            set { app = value; }
        }

    }



    [AttributeUsage(AttributeTargets.All)]
    public class HttpAction : Attribute
    {
        public HttpMethod HttpMethod { get; set; }
        public HttpType _Http { get; set; }

        public string ControllerName { get; set; }
        public HttpAction(HttpType http)
        {
            _Http = http;


            CreateMethodType();
        }

        private void CreateMethodType()
        {
            HttpMethod = HttpMethod.Get;
            if (_Http == HttpType.Get)
            {
                HttpMethod = HttpMethod.Get;
            }
            if (_Http == HttpType.Post)
            {
                HttpMethod = HttpMethod.Post;
            }
        }


    }

    public enum HttpType
    {
        Get,
        Post,
        Delete,
        Put
    }



}
