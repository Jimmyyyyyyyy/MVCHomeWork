using MVCHomeWork.Models;
using MVCHomeWork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountingService _accountingService;

        public HomeController()
        {
            _accountingService = new AccountingService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DataGridAction()
        {
            var data = _accountingService.Lookup();
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