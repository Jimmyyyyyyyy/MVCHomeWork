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
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DataGridAction()
        {
            var data = db.AccountBook.ToList();
            List<Accounting> result = new List<Accounting>();
            foreach (var item in data)
            {
                result.Add(new Accounting() {
                    Date = item.Dateee,
                    Money = item.Amounttt,
                    TypeOfMoney = item.Categoryyy
                });
            }

            result = result.OrderByDescending(x => x.Date).ToList();
            
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