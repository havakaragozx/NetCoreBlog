using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NetBlog.DAL.Entity;

namespace NetCoreBlog.BLL.Abstract
{
   public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
        bool AddCategory(Category category);
    }
}
