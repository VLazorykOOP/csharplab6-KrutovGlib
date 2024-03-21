using Lab6CSharp.First;
using System;

namespace Lab5CSharp.First
{
    internal class DairyProduct : Product
    {
        public string? Origin {get; set;}
        public DairyProduct()
        {

        }

        public DairyProduct(string name, double price, string origin) : base(name, price)
        {
            Origin = origin;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($"Country = {Origin}");
        }

        ~DairyProduct()
        {
            Console.WriteLine("DairyProduct destructor");
        }
    }
}
