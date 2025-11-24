using Microsoft.AspNetCore.Mvc;

namespace TrainingWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingWebApiController : ControllerBase
    {
        // Controller actions would go here
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from TrainingWebApiController");
        }
    }
}