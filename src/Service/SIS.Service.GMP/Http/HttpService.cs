using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIS.Service.RouteMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SIS.Service.Extensions;

namespace SIS.Service.GMP.Http
{
    public class HttpService : IDisposable
    {
        private bool disposed = false;
        private static HttpClient _httpClient;
        protected readonly string serviceBaseAddress;
        private readonly string addressSuffix;
        private RouteMapDTO routeMapDto;

        public HttpService(string serviceBaseAddress, string addressSuffix = null, string token = null)
        {
            this.serviceBaseAddress = serviceBaseAddress;
            this.addressSuffix = addressSuffix;
            _httpClient = GetHttpClientWithToken(serviceBaseAddress, token);
        }
        public HttpService(string baseUrl, bool useCookie)
        {
            this.serviceBaseAddress = baseUrl;

            HttpClientHandler _HttpClientHandler = new HttpClientHandler()
            {
                //UseProxy = false,
                //Proxy = null,

                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate

            };
            if (useCookie)
            {
                var cookieContainer = new CookieContainer();
                _HttpClientHandler.CookieContainer = cookieContainer;
            }

            _httpClient = new HttpClient(_HttpClientHandler);
            _httpClient.Timeout = TimeSpan.FromMinutes(30);
            _httpClient.BaseAddress = new Uri(serviceBaseAddress);
        }

        public HttpService(string serviceBaseAddress)
        {

            this.serviceBaseAddress = serviceBaseAddress;
            HttpClientHandler _HttpClientHandler = new HttpClientHandler()
            {
                //UseProxy = false,
                //Proxy = null,

                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate

            };
            _httpClient = new HttpClient(_HttpClientHandler);
            _httpClient.Timeout = TimeSpan.FromMinutes(30);
            _httpClient.BaseAddress = new Uri(serviceBaseAddress);
            //  _httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
        }
        private StringContent CreateJsonObjectContent<T>(T model) where T : class
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(model, new Newtonsoft.Json.JsonSerializerSettings { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
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
                        if (item.Value is decimal || item.Value is double)
                        queryParamters[item.Key] = item.Value.ToString().Replace(',', '.');
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


            httpResponseMessage = _httpClient.SendAsync(httpRequestMessage).Result;
            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;


            if (httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {

                    //  var   t = Task.Run(() => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result)).Result;
                    return IsValidJson(result) ? Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result) : result as T;
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

        public T Send3<T>(Dictionary<string, object> parameters)
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
                        if (item.Value is decimal || item.Value is double)
                        queryParamters[item.Key] = item.Value.ToString().Replace(',', '.');
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

            httpResponseMessage = _httpClient.SendAsync(httpRequestMessage).Result;

            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    if (typeof(T).Equals(typeof(decimal)) || typeof(T).Equals(typeof(double)))
                    {
                        result = result.Replace('.', ',');
                    }

                    return IsValidJson(result) ? Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result) : (T)Convert.ChangeType(result, typeof(T));
                }
                else
                {
                    return default;
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
                Content = httpContent,

            };


            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            var result = await httpResponseMessage.Content.ReadAsStringAsync();


            if (httpResponseMessage.IsSuccessStatusCode || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
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


        public async Task<T> SendAsync2<T>(Dictionary<string, object> parameters) where T : class
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

            //Stopwatch _Stopwatch = new Stopwatch();
            //_Stopwatch.Start();

            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            //_Stopwatch.Stop();
            //WebDebuggerHelper.do_Add_WebDebuggerDto(1, _Stopwatch.Elapsed.TotalMilliseconds, httpRequestMessage.RequestUri.ToString(), httpRequestMessage.Method.ToString(), result.Length, httpResponseMessage.StatusCode.ToString(), 0);


            if (httpResponseMessage.IsSuccessStatusCode || httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
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

        //public void SetRouteMap(string routeName)
        //{
        //    routeMapDto = HotelRouteMap.Map.FirstOrDefault(x => x.Name == routeName);
        //}
        public void Dispose()
        {
            throw new NotImplementedException();
        }



        private bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected virtual HttpClient GetHttpClientWithToken(string serviceBaseAddress, string token)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,

            };
            _httpClient = new HttpClient(handler);

            _httpClient.Timeout = TimeSpan.FromMinutes(30);
            _httpClient.BaseAddress = new Uri(serviceBaseAddress);
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            }
            else
            {
                _httpClient.DefaultRequestHeaders.Remove("Authorization");
            }
            _httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(StringWithQualityHeaderValue.Parse("gzip"));
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(StringWithQualityHeaderValue.Parse("deflate"));
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Sedna_HttpClient", "1.0")));
            return _httpClient;
        }

        public T Post<T, M>(M model) where T : class where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            var responseMessage = _httpClient.PostAsync(addressSuffix, objectContent).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                    catch
                    {
                        if (typeof(T) == typeof(string))
                        {
                            return (T)Convert.ChangeType(result.Replace("\"", ""), typeof(T));
                        }
                        return null;
                    }
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

        public T Get<T>() where T : class
        {
            var responseMessage = _httpClient.GetAsync(addressSuffix).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                    catch
                    {
                        if (typeof(T) == typeof(string))
                        {
                            return (T)Convert.ChangeType(result.Replace("\"", ""), typeof(T));
                        }

                        return null;
                    }
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

        public async Task<T> GetAsync<T>() where T : class
        {
            var responseMessage = await _httpClient.GetAsync(addressSuffix);
            var result = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                    catch
                    {
                        if (typeof(T) == typeof(string))
                        {
                            return (T)Convert.ChangeType(result.Replace("\"", ""), typeof(T));
                        }
                        return null;
                    }
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


        public T Get<T>(string path) where T : class
        {
            var responseMessage = _httpClient.GetAsync(path).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                    catch
                    {
                        if (typeof(T) == typeof(string))
                        {
                            return (T)Convert.ChangeType(result.Replace("\"", ""), typeof(T));
                        }
                        return null;
                    }
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
        public T Post<T, M>(string url, M model) where T : class where M : class
        {
            var requestMessage = new HttpRequestMessage();
            var objectContent = CreateJsonObjectContent(model);
            var responseMessage = _httpClient.PostAsync(url, objectContent).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.StatusCode == HttpStatusCode.OK || responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                    catch
                    {
                        if (typeof(T) == typeof(string))
                        {
                            return (T)Convert.ChangeType(result.Replace("\"", ""), typeof(T));
                        }
                        return null;
                    }
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

    }
}
