using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bands.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bands.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BandController : ControllerBase
    {
        private readonly ILogger<BandController> _logger;

        public BandController(ILogger<BandController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Band> Get()
        {
            var bands = new List<Band>();
            var band = new Band();
            band.Name = "Yes";
            band.Origin = "London, England";
            band.Genre = "Rock";
            bands.Add(band);
            return bands;
        }
    }
}