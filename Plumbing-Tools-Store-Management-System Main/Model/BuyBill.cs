using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    internal class BuyBill
    {
        public int ID { get; set; }
        public DateTime BuyDate { get; set; }
        public string Notes { get; set; }
        public double Discount { get; set; } = 0;
        public double Total { get; set; }
        public double TotalQty { get; set; }

        public Supplier Supplier { get; set; }
        public List<BuyBillDetails> BuyBillDetails { get; set; }
    }
}
