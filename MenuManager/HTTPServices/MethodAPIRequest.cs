using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MenuManager.HTTPServices
{
    public class MethodAPIRequest
    {

        static readonly HttpClient client = new HttpClient();
        public IConfiguration Configuration { get; set; }
        public MethodAPIRequest(){}
        public MethodAPIRequest(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task<JArray> GetRequestAsync(String url)
        {
            JArray data = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                //client.BaseAddress = new Uri(Configuration["APISETTINGS:APISETTINGS"]);
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

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
    }
}
