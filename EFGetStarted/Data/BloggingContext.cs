using EFGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Data
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // Warning: Connection strings should not be stored in the code for production applications demo purposes
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=blogging.db");
    }
}