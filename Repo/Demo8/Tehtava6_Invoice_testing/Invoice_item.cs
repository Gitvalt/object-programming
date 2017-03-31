using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6_Invoice_testing
{
    public class Invoice_item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        public Invoice_item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Total = price * quantity;
        }

        public override string ToString()
        {
            return  Name + "\t" + Price + "e\t" + Quantity + " pieces "
                + Total + "e total";
        }
    }
}
