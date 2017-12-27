using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet]
        [Route("user")]
        public IActionResult user()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            TempData["Variable"] = new String(stringChars);

            return Json(TempData);
        }



    }
}
