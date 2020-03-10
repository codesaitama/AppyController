using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MenuManager.HTTPServices
{
    public class MethodAPIRequest
    {

        static readonly HttpClient client = new HttpClient();
        public IConfiguration Configuration { get; set; }
        public MethodAPIRequest(){}
        public MethodAPIRequest(IConfiguration configuration){
            Configuration = configuration;
        }
        public async Task<string> MakeRequestAsync(string url, string method, object dataToSend = null){
            string data = null;

            HttpResponseMessage response = null;
<<<<<<< HEAD

            switch (method){
=======
            switch (method)
            {
<<<<<<< HEAD
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    data = JArray.Parse(responseContent);
                    return data;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized || response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return data;
                }

=======
>>>>>>> 24a183e0151fe90d249b04d2d3d70db31b1752c4
                case "GET":
                    response = await client.GetAsync(url);
                    break;
                case "POST":
                    response = await client.PostAsync(url, new StringContent(dataToSend.ToString(), Encoding.UTF8, "application/json"));
                    break;
                case "PUT":
                    response = await client.PutAsync(url, new StringContent(dataToSend.ToString(), Encoding.UTF8, "application/json"));
                    break;
                case "DELETE":
                    response = await client.DeleteAsync(url);
                    break;
            }
            if (response.IsSuccessStatusCode){
                var responseContent = await response.Content.ReadAsStringAsync();
                data = responseContent;
>>>>>>> 8c4ea296689fd4fd3f5b277e0baaf9057221015f
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized || response.StatusCode == System.Net.HttpStatusCode.Unauthorized){
                return "Unauthorized";
            }
            return data;
        }
    }
}
