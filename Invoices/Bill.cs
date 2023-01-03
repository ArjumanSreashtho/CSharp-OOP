using CSharp_OOP.Invoices.Base;
using CSharp_OOP.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Invoices
{
    internal class Bill: Invoice
    {
        public double ShippingCharge { get; set; }
        public double Coupon { get; set; }

        public Bill(IProduct[] Products,double ShippingCharge, double Coupon): base(Products)
        {
            this.ShippingCharge = ShippingCharge;
            this.Coupon = Coupon;
        }
        public override double TotalPrice()
        {
            double total = SubtotalPrice() + ShippingCharge - Coupon;
            return total;
        }

        public double SubtotalPrice()
        {
            double subTotal = 0;
            foreach (var product in Products)
            {
                subTotal += product.UnitPrice * product.Quantity;
            }
            return subTotal;
        }
    }
}
