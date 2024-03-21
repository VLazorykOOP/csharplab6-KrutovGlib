using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal interface ICreditor
    {
        void SetLoan(DateTime issueDate, double amount, double interestRate, double remainingBalance); // Встановити кредит
    }
}
