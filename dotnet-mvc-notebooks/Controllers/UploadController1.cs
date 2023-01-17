using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_notebooks.Controllers
{
    public class UploadController1 : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
