using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using RWPLEntityModel;

namespace Base.Software
{
    public static class Services1
    {
        //public static ResultResponse<T> GetServiceResponse<T>(string servicePath, ReportRequest request) where T : Entity
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri("http://localhost:4005/")
        //    };

        //    // Add an Accept header for JSON format.
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //    var json = JsonConvert.SerializeObject(request);
        //    HttpContent requestContent = new StringContent(json);
        //    requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var httpResponse = client.PostAsync(servicePath, requestContent).Result;

        //    var response = new ResultResponse<T>();
        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        response = JObject.Parse(httpResponse.Content.ReadAsStringAsync().Result).ToObject<ResultResponse<T>>();
        //    }
        //    else
        //    {
        //        response.Exception = new Exception(string.Format("Status Code : {0}", httpResponse.StatusCode));
        //    }

        //    return response;
        //}

        //public static ResultResponse<T> GetServicePageDataResponse<T>(string servicePath)
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri("http://localhost:4005/")
        //    };

        //    // Add an Accept header for JSON format.
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //    var httpResponse = client.GetAsync(servicePath).Result;

        //    var response = new ResultResponse<T>();
        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        response = JObject.Parse(httpResponse.Content.ReadAsStringAsync().Result).ToObject<ResultResponse<T>>();
        //    }
        //    else
        //    {
        //        response.Exception = new Exception(string.Format("Status Code : {0}", httpResponse.StatusCode));
        //    }

        //    return response;
        //}

        //public static ResultResponse<T> SaveServiceResponse<T>(T entity) where T : Entity
        //{
        //    var serviceAssembly = typeof(DispatchDataService).Assembly;
        //    var t = serviceAssembly.GetType(serviceAssembly.GetName().Name + "." + typeof(T).Name + "DataService");

        //    var method = t.BaseType.GetMethod("Save", BindingFlags.Public | BindingFlags.Static);

        //    return (ResultResponse<T>)method.Invoke(null, new object[] { entity });
        //}
    }
}
