using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.First
{
    internal interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        void Show();

    }
}
