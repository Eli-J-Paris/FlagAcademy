using FlagAcademy.Models;
using Microsoft.EntityFrameworkCore;

namespace FlagAcademy.DataAccess
{
    public class FlagAcademyContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<GameTracker> GameTrackers { get; set; }
        public FlagAcademyContext(DbContextOptions<FlagAcademyContext> options) : base(options)
        {

        }
    }
}
