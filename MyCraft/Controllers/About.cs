using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCraft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {
        private readonly ILogger<AboutController> logger;
        private readonly Random rng = new Random();

        public AboutController(ILogger<AboutController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
            logger.LogTrace($"{nameof(AboutController)} called");
            return new List<string>
            {
                "About MyCraft", 
                "Created by Barefoot, and lvl2 studios.",
                "Nov, 2020"
            };
        }
    }
}
