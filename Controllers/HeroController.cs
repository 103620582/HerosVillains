using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace GameAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {

        private readonly ILogger<HeroController> _logger;

        public HeroController (ILogger<HeroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public static IEnumerable<Hero> Get() {
            return HeroDatabaseHandler.GetAllHeroes();
        }



// test 
        // static List<Hero> heroList = new List<Hero>() {

        //     new Hero(1, "Dummy Hero", 0, 6, 3),
        // };
        // SqlConnection connection = new SqlConnection("SwinJoy.mssql.somee.com");

        // [HttpGet]
        // public IEnumerable<Hero> GetHeroes() {
        //     return heroList;
        // }

        // [HttpGet("{HeroId}")]
        // public Hero GetHeroById(int HeroId) {
        //     if (HeroId > -1 && HeroId < this.Hero.Count()) {
        //         return this.Hero[HeroId - 1];
        //     }
        //     return null;
        // }

        // [HttpPut]
        // public string
        
    }
}
