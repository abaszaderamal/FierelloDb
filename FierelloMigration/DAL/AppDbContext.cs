using FierelloMigration.Models;
using Microsoft.EntityFrameworkCore;

namespace FierelloMigration.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider>Sliders{ get; set; }

        public DbSet<SliderText> SliderText { get; set; }

    }
}
 