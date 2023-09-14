using System;
using System.Collections.Generic;
using System.Data.Entity;
using EntityLayer.Entites;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Context
{
    public class DataContext:DbContext
    {
        private static readonly string connectionString = "Server=DESKTOP-N4J0NPU\\SQLEXPRESS;Database=E-Ticaret;MultipleActiveResultSets=true; integrated security=true;";

        public DataContext(): base(connectionString)
        {
            
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet <Comment> Comments { get; set; }

    }
}
