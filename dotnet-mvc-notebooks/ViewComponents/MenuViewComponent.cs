using dotnet_mvc_notebooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnet_mvc_notebooks.ViewComponents
{

    [ViewComponent(Name = "MenuList")]
    public class MenuViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            string[] paths = $"{Request.Path}".Split('/');

            var sidebar_data = new Sidebar[]
            {
                new Sidebar{ Name = "content" , Url = "home_content_page", Icon = "fas fa-envelope" , Path = paths.Contains("content") ? "active" : "" },
                new Sidebar{ Name = "privacy" , Url = "home_privacy_page"  , Icon = "fas fa-wallet" , Path = paths.Contains("privacy") ? "active" : "" },
            };

            ViewData["sidebar_data"] = sidebar_data;

            return View("_Sidebar");
        }
    }
}
