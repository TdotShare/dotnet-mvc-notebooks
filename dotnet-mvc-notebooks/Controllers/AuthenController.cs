using dotnet_mvc_notebooks.Models;
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


        [HttpPost("auth/login", Name = "auth_login_data")]
        public IActionResult Login(Login login_data)
        {

            var data = login_data;

            return Json(data);
            //return Ok(new { data = login_data });
        }
    }
}
