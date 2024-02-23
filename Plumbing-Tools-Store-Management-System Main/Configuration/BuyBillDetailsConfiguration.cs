using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Configuration
{
    internal class BuyBillDetailsConfiguration : EntityTypeConfiguration<BuyBillDetails>
    {
        public BuyBillDetailsConfiguration()
        {
            this.HasKey(b => new { b.BuyBillID, b.ProductID });
            this.HasRequired(b => b.BuyBill)
                .WithMany(b => b.BuyBillDetails)
                .HasForeignKey(b => b.BuyBillID);
            this.HasRequired(b => b.Product)
                .WithMany(p => p.BuyBillDetails);
        }
    }
}
