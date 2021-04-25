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


    public class ConnectionDTO
    {
        public ConnectionDTO()
        {
            Server = "";
            Database = "";
            UserId = "";
            Password = "";
        }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public string Connection(bool _Cloude)
        {
            string _return = $"data source= {Server};initial catalog={Database};persist security info=True;user id={UserId};password={Password};MultipleActiveResultSets=True;App=EntityFramework";
            if (_Cloude)
            {
                _return = $"Server = tcp:{Server},1433; Initial Catalog = {Database}; Persist Security Info = False; User ID = {UserId}; Password = {Password}; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            }

            return _return;
        }
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
