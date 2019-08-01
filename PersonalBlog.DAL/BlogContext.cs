using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;

namespace PersonalBlog.DAL
{
    public class BlogContext: DbContext 
    {
        public BlogContext(string connectionString)
            :base(connectionString)
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
