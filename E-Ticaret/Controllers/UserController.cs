using DataAccesLayer.Context;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace E_Ticaret.Controllers
{
    public class UserController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Update()
        {
            var username = (string)Session["Mail"];
            var degerler = db.Users.FirstOrDefault(x=>x.Email == username);
            return View(degerler);
        }

        [HttpPost]
        public ActionResult Update(User data) 
        {
            var username = (string)Session["Mail"];
            var user = db.Users.Where(x => x.Email == username).FirstOrDefault();
            user.Name = data.Name;
            user.SurName = data.SurName;
            user.UserName = data.UserName;
            user.Email = data.Email;
            user.Password = data.Password;
            user.RePassword = data.RePassword;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}