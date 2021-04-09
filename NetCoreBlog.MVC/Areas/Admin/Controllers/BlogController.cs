using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetBlog.DAL.Entity;
using NetCoreBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBlog.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogRepository blogRepository;
        private readonly ICategoryRepository categoryRepository;

        public BlogController(IBlogRepository blogRepository,ICategoryRepository categoryRepository)
        {
            this.blogRepository = blogRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(blogRepository.GetBlogs());
        }
        public IActionResult AddBlog()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetCategories(), "ID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
           
            if (ModelState.IsValid)
            { 
                bool result = blogRepository.AddBlog(blog);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                 else { return View(); }
            }
            return View();
        }
    }
}
