using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6_Invoice_testing
{
    public class Invoice
    {
        public string Customer { get; set; }
        public List<Invoice_item> InLista { get; set; }
        public string tuotteet { get; set; }
        public double tuotteet_total { get; set; }


        public Invoice(string customer, List<Invoice_item> list)
        {
            Customer = customer;
            InLista = list;

            foreach (Invoice_item item in InLista) { 
            tuotteet_total = tuotteet_total + item.Total;
            }

        }

        public string PrintInvoice()
        {
           
            string complete;
            string alku = "Customer " + Customer + "'s" + " invoice:";
            string two = "\n===============================\n";

            foreach (Invoice_item item in InLista)
            {
                 tuotteet += item + "\n";       
            }

            

            complete = alku + two + tuotteet + two + "Total : " + tuotteet_total + " euros";
            return complete;
        }

    }
}
