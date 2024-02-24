using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    public class SellBillDetails
    {
        public int SellBillID { get; set; }

        public SellBill SellBill { get; set; }
        public int ProductID { get; set; }

        public Product Product { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        //public double Discount { get; set; }
        public double Total { get; set; }
    }
}
