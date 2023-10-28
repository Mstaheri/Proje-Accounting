using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL.Domain
{
    public class ProductRegistration
    {
        [Key]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public int PurchasePrice { get; set; }
        public int SalesPrice { get; set; }
        public string BarCode { get; set; }
    }
}
