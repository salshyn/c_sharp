using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class ContactController : Controller
    {


        [HttpGet]
        [Route("contact")]
        public IActionResult contact()
        {
            return View("Contact");
        }
    }
}
