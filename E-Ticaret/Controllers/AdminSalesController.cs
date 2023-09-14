using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using DataAccesLayer.Context;

namespace E_Ticaret.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSalesController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index(int sayfa =1)
        {
            return View(db.Sales.ToList().ToPagedList(sayfa,5));
        }
    }
}