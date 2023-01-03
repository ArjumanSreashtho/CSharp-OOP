using CSharp_OOP.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Invoices.Base
{
    abstract class Invoice
    {
        public int TotalItems { set; get; }
        public IProduct[] Products { get; set; }
        public Invoice(IProduct[] Products)
        {
            int totalItems = 0;
            this.Products = Products;
            foreach(IProduct product in Products)
            {
                totalItems += product.Quantity;
            }
            TotalItems = totalItems;
        }
        abstract public double TotalPrice();

    }
}
