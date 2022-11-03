using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShopStorege.Models;
using TopShopStorege.Models.Base;
using TopShopStorege.Repository;

namespace TopShopStorege.DataBase
{
    internal class StoregShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ProductBasket> ProductBaskets { get; set; }
        public DbSet<ProductStorage> ProductStorages { get; set; }
        public DbSet<Saller> Sallers { get; set; }
        public DbSet<ShopManager> ShopManagers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1423;User ID=sa;Password=MoldovaN92#!;Database=ShopStore");
    }

    
}
