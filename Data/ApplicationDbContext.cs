using CatalogFootballPlayers3.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogFootballPlayers3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Footballer> Footballer { get; set;}

    }
}
