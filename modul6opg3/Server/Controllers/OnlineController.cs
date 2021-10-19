using modul6opg3.Shared;
using modul6opg3.Server;
using modul6opg3.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace modul6opg3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnlineController : ControllerBase
    {
        string url = "indkobData.json";

        private readonly ILogger<OnlineController> logger;

        public OnlineController(ILogger<OnlineController> logger)
        {
            this.logger = logger;
        }

        HttpClient client = new HttpClient();
        

[HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            return
        }
        
    }
}
