using Microsoft.AspNetCore.Mvc;

namespace challengeAlternativo.Controllers
{
    [ApiController]
    [Route(template:"Api/[Controller]")]

    public class ContinentController : ControllerBase
    {
        public ContinentController()
        {
        }
        [HttpGet]
        public IActionResult Get()
        {
            var test = 5;
            return NoContent();
        }
    }
}
