using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_notebooks.Controllers
{
    public class AuthenController : Controller
    {

        [HttpGet("auth" , Name = "auth")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
