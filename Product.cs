using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Class_Extention
{
    public class Product
    {
        private static int _nocount = 0;
        public int No { get; }
        public string Name { get; set; }
        public int Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
        }

        public Product(string name, int price, string type, int count)
        {
            No = ++_nocount;
            Name = name;
            Price = price;
            Type = type;
            Count = count;
        }

        public int Count { get; set; }
        public string Type { get; set; }
        

        public override string ToString()
        {
            return $"No:{No},Name:{Name},Price:{Price},Count:{Count},Type:{Type}" ;
        }
    }
}
