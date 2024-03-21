using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal interface IOrganization
    {
        void SetAccount(DateTime openDate, string accountNumber, double balance); // Встановити рахунок
    }
}
