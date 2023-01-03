using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Product.Interfaces
{
    internal interface IProduct
    {
        string Name { set; get; }
        double UnitPrice { set; get; }
        public int Quantity { get; set; }
    }
}
