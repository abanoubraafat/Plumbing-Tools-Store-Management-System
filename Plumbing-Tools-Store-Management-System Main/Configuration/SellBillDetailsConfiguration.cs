using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Configuration
{
    internal class SellBillDetailsConfiguration : EntityTypeConfiguration<SellBillDetails>
    {
        public SellBillDetailsConfiguration()
        {
            this.HasKey(b => new { b.SellBillID, b.ProductID });
            this.HasRequired(b => b.SellBill)
                .WithMany(p => p.SellBillDetails)
                .HasForeignKey(b => b.SellBillID);
            this.HasRequired(b => b.Product)
                .WithMany(p => p.SellBillDetails)
                .HasForeignKey(b => b.ProductID);
        }
    }
}
