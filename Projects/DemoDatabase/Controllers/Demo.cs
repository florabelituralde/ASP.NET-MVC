using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoDatabase.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int empId)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["EmpId"] = empId;

            return View();
        }
    }
}
