using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetBlog.DAL.Entity;
using NetBlog.DAL.Entity.AppUserEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBlog.DAL.Context
{
    public class BlogDbContext : IdentityDbContext<AppUser>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
    }
    

