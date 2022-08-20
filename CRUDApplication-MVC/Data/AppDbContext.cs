using CRUDApplication_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApplication_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
