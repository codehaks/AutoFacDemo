using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacDemo.Controllers
{
    public class TestController : Controller
    {
        [Route("api/test")]
        public IActionResult Index()
        {
            return Ok("done!");
        }
    }
}