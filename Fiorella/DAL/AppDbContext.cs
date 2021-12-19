using Fiorella.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderIntro> SliderIntro { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InfoVideo> InfoVideo { get; set; }
        public DbSet<InfoIntro> InfoIntro { get; set; }
        public DbSet<ExpertIntro> ExpertIntros { get; set; }
        public DbSet<ExpertInfo> ExpertInfos { get; set; }
        public DbSet<BlogIntro> BlogIntros { get; set; }
        public DbSet<BlogInfo> BlogInfos { get; set; }
        public DbSet<Review> Reviews { get; set;}


    }
}
