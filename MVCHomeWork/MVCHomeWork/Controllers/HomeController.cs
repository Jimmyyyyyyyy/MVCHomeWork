using MVCHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DataGridAction()
        {
            Random rnd = new Random();
            DateTime dateTimeMin = Convert.ToDateTime("2019-1-1");
            List<Accounting> data = new List<Accounting>();
            for (int i = 1; i <= 100; i++)
            {
                int num = rnd.Next(365);

                Accounting tmp = new Accounting() { TypeOfMoney = rnd.Next(1, 3), Date = dateTimeMin.AddDays(num), Money = rnd.Next() };
                data.Add(tmp);
            }

            var result = data;
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}