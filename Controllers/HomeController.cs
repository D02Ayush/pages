using Microsoft.AspNetCore.Mvc;

namespace Controllers
{

    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Kubernetes!";
        }
    }
}