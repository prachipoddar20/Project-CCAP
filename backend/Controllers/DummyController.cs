using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAP.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class DummyController: ControllerBase
    {
        [HttpGet]
        public IActionResult Greet()
        {
            return Ok("Good afternoon!");
        }
    }
}
