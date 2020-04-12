using Interpol.Models;
using Microsoft.EntityFrameworkCore;

namespace Interpol.Data {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context) {
            
        }
        public DbSet<Criminal> Criminals { get; set; }
        public DbSet<Crime> Crimes { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
    }
}