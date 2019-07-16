using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.DataAccess
{
    public class EFCoreContext:DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options):base(options)
        {

        }

        public EFCoreContext()
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(@"Server=localhost;Database=CampTest;User=root;Password=47854785zZ.;");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
