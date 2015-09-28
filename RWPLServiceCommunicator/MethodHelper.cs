using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RWPLEntityModel;

namespace RWPLServiceCommunicator
{
    public static class Services
    {
        public static ResultResponse<T> GetServiceResponse<T>(string servicePath, ReportRequest request) where T : Entity
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:4005/")
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonConvert.SerializeObject(request);
            HttpContent requestContent = new StringContent(json);
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var httpResponse = client.PostAsync(servicePath, requestContent).Result;

            var response = new ResultResponse<T>();
            if (httpResponse.IsSuccessStatusCode)
            {
                response = JObject.Parse(httpResponse.Content.ReadAsStringAsync().Result).ToObject<ResultResponse<T>>();
            }
            else
            {
                response.Exception = new Exception(string.Format("Status Code : {0}", httpResponse.StatusCode));
            }

            return response;
        }
    }
}
