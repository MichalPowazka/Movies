using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
           
        }
    }
}