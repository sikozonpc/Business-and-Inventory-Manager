using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public string Provider { get; set; }
        public string ReceiptDate { get; set; }
        public string Location { get; set; }
    }
}
