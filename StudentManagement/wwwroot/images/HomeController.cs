using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.wwwroot.images
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Hello World from MVC.";
        }

        //public JsonResult Index()
        //{
        //    return Json(new { id = "1", name = "张三" });
        //}
    }
}