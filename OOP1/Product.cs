using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        //Id
        public int Id { get; set; }
        //Kategori Id
        public int CategoryId { get; set; }
        //Ürün İsmim
        public string ProductName { get; set; }
        //Birim Fiyat
        public double UnitPrice { get; set; }
        //Stoktaki Birimler
        public int UnitsInStock { get; set; }


    }
}
