using CSharp_OOP.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Product
{
    internal class PhysicalProduct: IProduct
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public PhysicalProduct(string name, int quantity, double unitPrice) 
        {
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
