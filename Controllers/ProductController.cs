using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySQLTestPrj.Models;

namespace MySQLTestPrj.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductStoreContext context = HttpContext.RequestServices.GetService(typeof(ProductStoreContext)) as ProductStoreContext;

            return View(context.GetAllProducts());
 
        }
    }
}