using dotnet_mvc_notebooks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnet_mvc_notebooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var breadcrumb_list = new Breadcrumb[]
            {
                new Breadcrumb{ Name = "test 1", Url = "#"},
                new Breadcrumb{ Name = "test 2", Url = ""}
            };

            ViewData["titleheader_data"] = new TitleHeader
            {
                Name = "test - Main",
                Breadcrumbs = breadcrumb_list
            }; ;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}