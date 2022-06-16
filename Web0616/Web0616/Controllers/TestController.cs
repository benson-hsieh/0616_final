using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web0616.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eaxm()
        {
            return View();
        }
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(string name, int number) 
        {
            string[] a = { "", "do", "re", "mi", "fa", "so", "la", "si", "do" };
            var result = "";
            if (number <= 1 && number <= 7)
            {
                result = a[number];
            }
            else
            {
                result = "錯誤";
            }


            ViewBag.Name = name;
            ViewBag.Result = result;

            return View();
        }
    }
}