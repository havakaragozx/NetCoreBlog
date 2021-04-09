using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBlog.MVC.Areas.Admin.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
