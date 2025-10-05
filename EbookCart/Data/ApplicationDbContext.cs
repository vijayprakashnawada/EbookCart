using EbookCart.Models;
using Microsoft.EntityFrameworkCore;

namespace EbookCart.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
