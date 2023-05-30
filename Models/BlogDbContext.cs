using Microsoft.EntityFrameworkCore;

namespace WebBlogMVC.Models
{
    public class BlogDbContext : DbContext

    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
