using Microsoft.EntityFrameworkCore;
using TheDevBlog.Models.Entities;

namespace TheDevBlog.Data
{
    public class TheDevBlogDbContext : DbContext
    {
        public TheDevBlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
