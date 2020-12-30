using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Green", "Turkish tea", "black tea", "light tea", "english tea"
        };

        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Teas[rng.Next(Teas.Length)]);
        }
        
    }
    
}