using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string textToPass)
        {
            ViewBag.Word = textToPass;
            Console.WriteLine(textToPass);
            return View("Result");
        }
    }
}
