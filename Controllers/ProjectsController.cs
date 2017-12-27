using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class ProjectsController : Controller
    {


        [HttpGet]
        [Route("projects")]
        public IActionResult projects()
        {
            return View("Projects");
        }
    }
}
