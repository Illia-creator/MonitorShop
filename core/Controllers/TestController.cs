using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/test")]
        public IActionResult Get()
        {
            return Ok(new { name = "Bob" });
        }
    }
}
