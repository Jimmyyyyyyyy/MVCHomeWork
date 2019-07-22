using MVCHomeWork.Models;
using MVCHomeWork.Repository;
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
        //private readonly AccountingService _accountingService;
        private readonly AccountingService _accountingService;
        private readonly LogService _logService;
        private readonly UnitOfWork _unitOfWork;

        public HomeController()
        {
            //_accountingService = new AccountingService();
            _unitOfWork = new UnitOfWork();
            _logService = new LogService(_unitOfWork);
            _accountingService = new AccountingService(_unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DataGridAction()
        {
            var data = _accountingService.Lookup().ToList();
            data = data.OrderByDescending(x => x.Date).ToList();
            
            return View(data);
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