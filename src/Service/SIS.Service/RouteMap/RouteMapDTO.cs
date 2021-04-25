using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SIS.Service.RouteMap
{
    public class RouteMapDTO
    {
        public string Name { get; set; }
        public string Route { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}
