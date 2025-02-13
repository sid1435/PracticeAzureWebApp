using Microsoft.EntityFrameworkCore;
using PracticeAzureWebApp.Models;

namespace PracticeAzureWebApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
