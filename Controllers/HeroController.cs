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
    public class HeroController : ControllerBase
    {
        private readonly ILogger<HeroController> _logger;
        static List<Hero> heroList = new List<Hero>() {

            new Hero(1, "Michael Jackson", 0, 6, 3),
            new Hero(2, "Tupac Shakur", 0, 8, 5),
            new Hero(3, "Amy Winehouse", 3, 10, 4)
        };

        // SqlConnection connection = new SqlConnection("----somee database url----");

        [HttpGet]
        public IEnumerable<Hero> GetHeroes() {
            return heroList;
        }


        
    }
}
