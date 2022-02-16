using MVCPartialDevamTekrar_1.DesignPatterns.SingletonPattern;
using MVCPartialDevamTekrar_1.Models;
using MVCPartialDevamTekrar_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartialDevamTekrar_1.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities _db;

        List<Product> _products;
        List<Category> _categories;

        public HomeController()
        {
            _db = DBTool.DBInstance;
            _products = _db.Products.ToList();
            _categories = _db.Categories.ToList();
        }

        public ActionResult Index()
        {
            HomeVM hvm = new HomeVM
            {
                Employees = _db.Employees.ToList()
            };

            return View(hvm);
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

        public PartialViewResult GetAllCategories()
        {
            HomeVM hvm = new HomeVM
            {
                Categories = _categories
            };

            return PartialView("_CategoryPartial",hvm);
        }

        public PartialViewResult GetAllProducts()
        {
            HomeVM hvm = new HomeVM
            {
                Products = _products
            };

            return PartialView("_ProductPartial",hvm);
        }
    }
}