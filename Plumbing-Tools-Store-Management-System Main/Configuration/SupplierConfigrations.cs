using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Configuration
{
    internal class SupplierConfigrations : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfigrations() { 
             
            //this.Property(e=>e.Name).IsRequired();
            //this.Property(e=>e.Address).IsRequired();
            //this.Property(e => e.CompanyName).IsRequired();
            ////this.Property(e=>e.Phone).IsRequired();
            //this.Property(e=>e.Notes).IsOptional();
        
        }


    }
}
