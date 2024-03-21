using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal class Organization : Client, IOrganization
    {
        protected DateTime accountOpenDate; // Дата відкриття рахунку
        protected string accountNumber; // Номер рахунку
        protected double accountBalance; // Сума на рахунку

        public Organization(string name) : base(name)
        {
        }

        public void SetAccount(DateTime openDate, string accountNumber, double balance)
        {
            accountOpenDate = openDate;
            this.accountNumber = accountNumber;
            accountBalance = balance;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Organization: {lastName}");
            Console.WriteLine($"Account Open Date: {accountOpenDate}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Balance: {accountBalance}");
        }

        public override bool MatchDate(DateTime date)
        {
            return accountOpenDate.Date == date.Date;
        }
    }
}
