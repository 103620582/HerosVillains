using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VillainController : ControllerBase
    {

        private readonly ILogger<VillainController> _logger;
        
        public VillainController (ILogger<VillainController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public static IEnumerable<Villain> GetAllVillains() {
            return VillainDatabaseHandler.GetAllVillainsFromDB();
        }

        // static List<Villain> villainList = new List<Villain>() {

        //     new Villain(3, "Donald Trump", 0),
        //     new Villain(666, "Whiterose", 0)
        // };

        // [HttpGet]
        // public IEnumerable<Villain> GetVillains() {
        //     return villainList;
        // }

        // [HttpPut]
        // public List

    }

}
