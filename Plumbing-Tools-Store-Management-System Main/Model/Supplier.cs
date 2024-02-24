using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumbing_Tools_Store_Management_System_Main.Model
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //[Phone]
        public string Phone {  get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string Notes { get; set; }
        public List<BuyBill> SupplierBills { get; set; }
    }
}
