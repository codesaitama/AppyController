using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MenuManager.HTTPServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace MenuManager.Controllers
{
    
    public class APICallsController : ControllerBase
    {
        MethodAPIRequest methodAPIRequest = new MethodAPIRequest();
        public IConfiguration Configuration { get; set; }
        public APICallsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        [HttpGet("home/project/getprojects")]
        public async Task<object> GetAllProjects()
        {
            var endpoint = $"{Configuration["APISETTINGS:MenuServiceAPI"]}Menus/GetAllMenus";
            return await methodAPIRequest.GetRequestAsync(endpoint);
        }

    }
}