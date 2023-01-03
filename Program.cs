using CSharp_OOP.Invoices;
using CSharp_OOP.Invoices.Base;
using CSharp_OOP.Product;
using CSharp_OOP.Product.Interfaces;

namespace CSharp_OOP
{
    public class Program
    {
        public static void Main() 
        {
            IProduct[] products = { new PhysicalProduct("PP-1", 1, 10.0), new DigitalProduct("DP-1", 2, 2, 7), new PhysicalProduct("PP-2", 3, 14.12) };
            Quotation quotation = new Quotation(products);
            Bill bill= new Bill(products, 10.00, 12);
            Console.WriteLine("Quotation\nTotal Price: "+ quotation.TotalPrice());
            Console.WriteLine();
            Console.WriteLine("Bill\nSub-Total Price: "+ bill.SubtotalPrice() + " Total Price: " + bill.TotalPrice());
        }
    }
}