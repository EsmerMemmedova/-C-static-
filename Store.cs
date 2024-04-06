using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class_Extention
{
    public class Store
    {
        private static int _id=0;
        public int Id { get;  }
        
        public Product[] products { get; set; }

        public Store()
        {
            Id = ++_id;
            products = new Product[0];
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public Product GetProduct(int no)
        {
            foreach (var product in products)
            {
                if (product.No == no)
                    return product;
            }
            return null;
        }

    }
}
