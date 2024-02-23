using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    internal class SellBill
    {
        public int ID { get; set; }
        public DateTime SellDate { get; set; }
        public string Notes { get; set; }
        public double Discount { get; set; } = 0;
        public double Total { get; set; }
        public double TotalQty { get; set; }
        public List<SellBillDetails> SellBillDetails { get; set; }
        //public List<Product> Products { get; set; }
    }
}
