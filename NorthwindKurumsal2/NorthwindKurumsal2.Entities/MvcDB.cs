using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Entities
{
    public class MvcDB : DbContext
    {
        public MvcDB()
            : base(@"Data Source=DESKTOP-4A941CM\SQLEXPRESS;Initial Catalog=wcfnortwind2;Integrated Security=True")
        {
        }
        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
