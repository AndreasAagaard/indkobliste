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

namespace modul6opg3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndkobController : ControllerBase
    {

        private readonly ILogger<IndkobController> logger;

        public IndkobController(ILogger<IndkobController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            return SampleData.FestListe;
        }
        
    }
}
