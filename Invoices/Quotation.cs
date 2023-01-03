using CSharp_OOP.Invoices.Base;
using CSharp_OOP.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Invoices
{
    internal class Quotation: Invoice
    {
        public Quotation(IProduct[] Products) : base(Products)
        {
        }

        public override double TotalPrice()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.UnitPrice * product.Quantity;
            }
            return total;

        }
    }
}
