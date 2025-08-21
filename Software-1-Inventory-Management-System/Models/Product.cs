using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_1_Inventory_Management_System.Models
{
    public class Product
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? ProductInventory { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? ProductMin { get; set; }
        public int? ProductMax { get; set; }
        public List<Part> AssociatedParts { get; set; } = new List<Part>();
        // Constructor
        /*public Product()
        {
            AssociatedParts = new List<Part>();
        }*/
    }
}
