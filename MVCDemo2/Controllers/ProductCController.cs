using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo2.Models;

namespace MVCDemo2.Controllers
{
    public class ProductCController : Controller
    {
        ProductDBContext db = new ProductDBContext();
        public IActionResult Index()
        {
            var ds = db.Products.ToList();
            return View(ds);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Search(String txtName)
        {
            var r = db.Products.Where(p => p.ProductName.Contains(txtName)).ToList();
            return View("Index", r);

        }
        public IActionResult DoCreate(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
           
        }
    }
}
