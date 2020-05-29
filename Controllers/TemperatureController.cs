using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TemperatureVisualiser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
       private readonly ILogger<TemperatureController> _logger;

        public TemperatureController(ILogger<TemperatureController> logger)
        {
            _logger = logger;
        }       

        [HttpPost]
        public IActionResult Post([FromBody] Temperature temperatureData)
        {
            DateTime date = temperatureData.Date;
            int temperatureC = temperatureData.TemperatureC;
            string summary = temperatureData.Summary;
            return Ok();
        }
    }
}
