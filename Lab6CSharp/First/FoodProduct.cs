using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.First
{
    internal class FoodProduct : Product
    {
        public int ShelfLife {  get; set; }

        public FoodProduct()
        {

        }
        
        public FoodProduct(string name, double price, int shelfLife) : base(name, price)
        {
            ShelfLife = shelfLife;
        }
    
        public void Show()
        {
            base.Show();
            Console.WriteLine($"Shelf Life : {ShelfLife}");
        }
        ~FoodProduct()
        {
            Console.WriteLine("Food Product destructor");
        }
    }
}
