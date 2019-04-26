using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

/*
 * a. 当来自浏览器的请求到达我们的应用程序时，作为 MVC 设计模式中的控制器，它处理传入的 http 请求并响应用户操作。 
 * b. 控制器构建模型（Model）。
 * c. 如果我们正在构建 API，则将模型数据返回给调用方。
 * d. 或者选择“View 视图”并将模型数据传递到视图，然后视图生成所需的 HTML 来显示数据。
*/
namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        /// <summary>
        /// 使用构造函数注入的方式注入 IStudentRepository
        /// </summary>
        /// <param name="studentRepository"></param>
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            // 返回学生的名字
            return _studentRepository.GetStudent(1).Name;
        }

        //public JsonResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    return Json(model);
        //}

        //public ObjectResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    return new ObjectResult(model);
        //}
        //public IActionResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    //return View(model);
        //    //return View("test");
        //    return View("~/MyViews/test.cshtml");
        //}
        public IActionResult Details()
        {
            Student model = _studentRepository.GetStudent(1);
            return View(model);

            /*
             * 将数据从控制器传递到视图的方法：
             *   a. 使用 ViewData
             *   b. 使用 ViewBag
             *   c. 强类型视图
             */

            /*
             * ViewData
             *   a. 是弱类型的字典（dictionary）对象
             *   b. 使用 string 类型的键值，存储和查询 ViewData 字典中的数据
             *   c. 运行时动态解析
             *   d. 没有智能感知，编译时也没有类型检查
             */
            //ViewData["PageTitle"] = "Student Details";
            //ViewData["Student"] = model;

            // 将 PageTitle 和 Student 模型对象存储在 ViewBag ，我们正在使用 PageTitle 和 Student
            //ViewBag.PageTitle = "学生详情";
            //ViewBag.Student = model;

            //return View();
            //return View("test");
            //return View("~/MyViews/test.cshtml");

            /*
             * ViewData 和 ViewBag 对比
             *  a. ViewBag 是 ViewData 的包装器
             *  b. 它们都创建了一个弱类型的视图
             *  c. ViewData 使用字符串键名，来存储和查询数据
             *  d. ViewBag 使用动态属性来存储和查询数据
             *  e. 均是在运行时动态解析
             *  f. 均不提供编译时类型检查，没有智能提示
             *  g. 首选方法是使用强类模型对象，将数据从控制器传递到视图
             */
        }
    }
}