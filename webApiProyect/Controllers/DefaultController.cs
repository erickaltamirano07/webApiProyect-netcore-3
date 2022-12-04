using Microsoft.AspNetCore.Mvc;

namespace webApiProyect.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController: ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running.....";
        }
    }
}
