using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bands.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bands.Web.Models;

namespace Bands.Web.Controllers
{
    public class BandController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult BandInfo()
        {
            var model = new Band();
            model.Name = "Yes";
            model.Origin = "London, England";
            model.Genre = "Rock";
            return View(model);
        }
        
        
    }
}