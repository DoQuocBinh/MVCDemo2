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
    }
}
