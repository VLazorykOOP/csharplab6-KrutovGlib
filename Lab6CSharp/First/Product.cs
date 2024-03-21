using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.First
{
    internal class Product : IProduct
    {
       public string Name {  get; set; }
       public double Price {  get; set; }
        
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name} \n Price: {Price}");
        }
        ~Product() {
            Console.WriteLine("Product Destructor");
        }

    }
}
