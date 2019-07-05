using Microsoft.AspNetCore.Mvc;

namespace firstASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

    }
}