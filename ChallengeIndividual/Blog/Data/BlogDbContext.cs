using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Post> Posts{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
