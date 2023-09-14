
using BusinessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using System.Web.WebSockets;
using EntityLayer.Entites;
using DataAccesLayer.Context;

namespace E_Ticaret.Controllers
{
    public class HomeController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        DataContext db = new DataContext();

        public ActionResult Index(int sayfa = 1)
        {
            
            {
                return View(productRepository.List().ToPagedList(sayfa,3));
            }
            
        }

        public ActionResult Search(string searchText)
        {
            List<Product> searchResults;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Veritabanından arama sorgusunu çalıştırın ve sonuçları alın
                searchResults = db.Products
                    .Where(p => p.Name.Contains(searchText))
                    .ToList();
            }
            else
            {
                // Arama metni boşsa, tüm ürünleri getirin veya istediğiniz şekilde işleyin.
                searchResults = db.Products.ToList();
            }

            return PartialView("_SearchResults", searchResults);
        }
    }
}