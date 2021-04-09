using NetBlog.DAL.Context;
using NetBlog.DAL.Entity;
using NetCoreBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreBlog.BLL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BlogDbContext blogDbContext;
        public CategoryRepository(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        public bool AddCategory(Category category)
        {
            blogDbContext.Categories.Add(category);
            if (blogDbContext.SaveChanges()>0)
            
                return true;
            
            return false;
        }

        public IQueryable<Category> GetCategories()
        {
            return blogDbContext.Categories;
        }
    }
}
