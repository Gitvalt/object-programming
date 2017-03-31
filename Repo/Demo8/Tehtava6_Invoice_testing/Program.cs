using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6_Invoice_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Invoice_item> lista_invoice = new List<Invoice_item>();

            Invoice_item cat = new Invoice_item("OIEIMUSTAKISU", 10.00, 1);
            Invoice_item cat2 = new Invoice_item("OIEIMUSTAKISU", 20.50, 1);
            Invoice_item cat3 = new Invoice_item("OIEIMUSTAKISU", 5.50, 2);
            Invoice_item cat4 = new Invoice_item("OIEIMUSTAKISU", 4.99, 3);
            Invoice_item cat5 = new Invoice_item("OIEIMUSTAKISU", 1.50, 10);

            lista_invoice.Add(cat);
            lista_invoice.Add(cat2);
            lista_invoice.Add(cat3);
            lista_invoice.Add(cat4);
            lista_invoice.Add(cat5);


            Invoice invoice = new Invoice("Customer",lista_invoice);


            Console.WriteLine(invoice.PrintInvoice());
           

            Console.ReadLine();

        }
    }
}
