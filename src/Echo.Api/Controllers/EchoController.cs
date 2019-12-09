using Microsoft.AspNetCore.Mvc;

namespace Echo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]string echo)
        {
            if (string.IsNullOrWhiteSpace(echo))
                return BadRequest();

            return Ok(echo);
        }
    }
}
