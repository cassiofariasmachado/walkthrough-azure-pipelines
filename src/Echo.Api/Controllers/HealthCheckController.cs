using Microsoft.AspNetCore.Mvc;

namespace Echo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Pulsing";
    }
}
