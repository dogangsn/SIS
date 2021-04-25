
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;
using SIS.Service.RouteMap;
using Newtonsoft.Json;
using SIS.Service.Extensions;

namespace SIS.Service.Admin.Http
{
    public class HttpService : IDisposable
    {
        private bool disposed = false;
        private static HttpClient _httpClient;
        protected readonly string serviceBaseAddress;
        private RouteMapDTO routeMapDto;

        public HttpService(string serviceBaseAddress)
        {
            this.serviceBaseAddress = serviceBaseAddress;

            HttpClientHandler _HttpClientHandler = new HttpClientHandler()
            {
                //Proxy = new WebProxy(serviceBaseAddress, false),
                //UseProxy = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            _httpClient = new HttpClient(_HttpClientHandler);

            _httpClient.BaseAddress = new Uri(serviceBaseAddress);
        }
        private StringContent CreateJsonObjectContent<T>(T model) where T : class
        {
            string json = JsonConvert.SerializeObject(model, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            var stringContent = new StringContent(json);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return stringContent;

        }
        public T Send<T>(Dictionary<string, object> parameters) where T : class
        {
            HttpResponseMessage httpResponseMessage;
            HttpContent httpContent = null;
            UriBuilder uriBuilder = new UriBuilder(_httpClient.BaseAddress + routeMapDto.Route);
            var queryParamters = HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in parameters)
            {

                if (item.Value.GetType().IsSimpleType())
                {
                    if (item.Value is DateTime)
                        queryParamters[item.Key] = Convert.ToDateTime(item.Value).ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        queryParamters[item.Key] = item.Value.ToString();
                }
                else
                {
                    httpContent = CreateJsonObjectContent(item.Value);
                }
            }

            uriBuilder.Query = queryParamters.ToString();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                Method = routeMapDto.HttpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };

            Stopwatch _Stopwatch = new Stopwatch();
            _Stopwatch.Start();

            httpResponseMessage = _httpClient.SendAsync(httpRequestMessage).Result;
            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            _Stopwatch.Stop();
            //WebDebuggerHelper.do_Add_WebDebuggerDto(0, _Stopwatch.Elapsed.TotalMilliseconds, httpRequestMessage.RequestUri.ToString(), httpRequestMessage.Method.ToString(), result.Length, httpResponseMessage.StatusCode.ToString(), 0);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }

        }

        public async Task<T> SendAsync<T>(Dictionary<string, object> parameters) where T : class
        {
            //HttpResponseMessage httpResponseMessage;
            HttpContent httpContent = null;
            UriBuilder uriBuilder = new UriBuilder(_httpClient.BaseAddress + routeMapDto.Route);
            var queryParamters = HttpUtility.ParseQueryString(string.Empty);
            foreach (var item in parameters)
            {
                if (item.Value.GetType().IsSimpleType())
                {
                    if (item.Value is DateTime)
                        queryParamters[item.Key] = Convert.ToDateTime(item.Value).ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        queryParamters[item.Key] = item.Value.ToString();
                }
                else
                {
                    httpContent = CreateJsonObjectContent(item.Value);
                }
            }

            uriBuilder.Query = queryParamters.ToString();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                Method = routeMapDto.HttpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };

            Stopwatch _Stopwatch = new Stopwatch();
            _Stopwatch.Start();

            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            _Stopwatch.Stop();
            //WebDebuggerHelper.do_Add_WebDebuggerDto(0, _Stopwatch.Elapsed.TotalMilliseconds, httpRequestMessage.RequestUri.ToString(), httpRequestMessage.Method.ToString(), result.Length, httpResponseMessage.StatusCode.ToString(), 0);


            if (httpResponseMessage.IsSuccessStatusCode || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception(result);
            }

        }
        public void SetRoute(RouteMapDTO route)
        {
            routeMapDto = route;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
