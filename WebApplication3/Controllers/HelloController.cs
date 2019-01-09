using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;


namespace WebApplication3.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet(@"api/HelloJson")]
        public JsonResult GetHelloJson()
        {
            return new JsonResult(new List<object>
                {
                    "HelloJson"
                }
            );
        }
    }
}