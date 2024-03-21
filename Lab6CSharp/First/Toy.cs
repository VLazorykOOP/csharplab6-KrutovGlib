using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.First
{
    internal class Toy : Product
    {
        public string Category {  get; set; }

        public Toy() { }
        public Toy(string name, double price, string category) : base(name, price)
        {
            Category = category;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"Category: {Category}");
        }
        ~Toy() {
            Console.WriteLine("Toy Destructor");
        }
    }
}
