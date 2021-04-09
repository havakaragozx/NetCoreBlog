using NetBlog.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreBlog.BLL.Abstract
{
   public interface IBlogRepository
    {
        IQueryable<Blog> GetBlogs();
        bool AddBlog(Blog blog);
        bool DeleteBlog(int id);
        Blog GetById(int id);
        bool UpdateBlog(Blog blog);

    }
}
