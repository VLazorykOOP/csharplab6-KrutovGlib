using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal interface IDepositor
    {
        void SetDeposit(DateTime openDate, double amount, double interestRate); // Встановити внесок
    }
}
