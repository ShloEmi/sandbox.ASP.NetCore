using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCraft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RngController : ControllerBase
    {
        private readonly ILogger<RngController> logger;
        private readonly Random rng = new Random();

        public RngController(ILogger<RngController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            logger.LogTrace($"{nameof(RngController)} called");
            return rng.Next(1, 6);
        }
    }
}
