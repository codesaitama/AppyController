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


        [HttpGet("api/project/getprojects")]
        public async Task<object> GetAllProjects()
        {   
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Projects/GetAllProjects";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "GET", null);
        }

        [HttpPost("api/project/postproject")]
        public async Task<object> PostProject([FromBody]object data)
        {
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Projects/CreateProject";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "POST", data);
        }

        [HttpPut("api/project/putproject/{projectId}")]
        public async Task<object> PutProject([FromBody]object data, string projectId)
        {
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Projects/{projectId}";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "PUT", data);
        }

        [HttpGet("api/application/getapplicationbyprojectid/{projectId}")]
        public async Task<object> GetApplicationsByProjectId(string projectId)
        {
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Applications/spGetAllApplicationByProjectId/{projectId}";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "GET", null);
        }

        [HttpPost("api/application/postapplication")]
        public async Task<object> CreateApplication([FromBody]object data)
        {
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Applications/CreateApplication";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "POST", data);
        }

        [HttpPut("api/application/putapplication/{applicationId}")]
        public async Task<object> UpdateApplication([FromBody]object data, string applicationId)
        {
            var endpoint = $"{Configuration["APISETTINGS:HCMMenuBuilderMicroservice"]}Applications/UpdateApplication/{applicationId}";
            return await methodAPIRequest.MakeRequestAsync(endpoint, "PUT", data);
        }
    }
}