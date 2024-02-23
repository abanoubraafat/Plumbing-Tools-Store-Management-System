using Plumbing_Tools_Store_Management_System_Main.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    internal class DataContext : DbContext
    {
        public DataContext() : base("name=PlumbingToolsStoreConnection")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new SellBillDetailsConfiguration());
            modelBuilder.Configurations.Add(new BuyBillDetailsConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfigrations());
        }
        public DbSet<BuyBill> BuyBills { get; set; }
        public DbSet<SellBill> SellBills { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<BuyBillDetails> BuyBillDetails { get; set; }
        public DbSet<SellBillDetails> SellBillDetails { get; set; }
    }
}
