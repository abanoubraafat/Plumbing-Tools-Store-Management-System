using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    public class Product
    {
        public int ID { get; set; }
        //code must be unique
        public string BarCode { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double SellPrice { get; set; }
        public double BuyPrice { get; set; }
        public string Image { get; set; }
        public List<BuyBillDetails> BuyBillDetails { get; set; }
        public List<SellBillDetails> SellBillDetails { get; set; }
        //public List<SellBill> SellBills { get; set; }
    }
}
