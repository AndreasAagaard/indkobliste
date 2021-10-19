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
{using System.Text.Json;
using System.Text.Json.Serialization;
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        string url = "indkobData.json";

        private readonly ILogger<ShopController> logger;

        public ShopController(ILogger<ShopController> logger)
        {
            this.logger = logger;
        }

        public List<ShoppingItem> LoadJson()
        {
            using (StreamReader r = new StreamReader(url))
            {
                string json = r.ReadToEnd();
                List<ShoppingItem> items = JsonConvert.DeserializeObject<List<ShoppingItem>>(json);
                return items;
            }
        }

        [HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            return LoadJson();
        }
        
    }
}
