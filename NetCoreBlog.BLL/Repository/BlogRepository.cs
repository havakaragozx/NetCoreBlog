using NetBlog.DAL.Context;
using NetBlog.DAL.Entity;
using NetCoreBlog.BLL.Abstract;
using System.Linq;


namespace NetCoreBlog.BLL.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext context;
        public BlogRepository(BlogDbContext context)
        {
            this.context = context;
        }
        public bool AddBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            if (context.SaveChanges() > 0)
                return true;
            return false;
            
        }

        public bool DeleteBlog(int id)
        {
            Blog blog= context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            if (context.SaveChanges() > 0) { return true; }
            else { return false; }
        }

        public IQueryable<Blog> GetBlogs()
        {
            return context.Blogs;
        }

        public Blog GetById(int id)
        {
           return context.Blogs.Find(id);
                 
        }

        public bool UpdateBlog(Blog blog)
        {
            context.Entry(blog).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (context.SaveChanges() > 0) return true;
            return false;

        }
    }
}
