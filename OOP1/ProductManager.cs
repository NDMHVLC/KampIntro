using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager//Ürün Müdürü
    {
        public void Add(Product product) //Ekleme
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) //Güncelleme
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        

    }
}
