using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public  class ETicaretDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database = BaharETicaret; Trusted_Connection=true", builder =>
            {

                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAdress> UserAdressies { get; set; }
        public DbSet<OrderBasket> OrderBaskets { get; set; }
        public DbSet<OrderProducts> OrderDetailss { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }

    }
}
