using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal class Depositor : Client, IDepositor
    {
        protected DateTime depositOpenDate; // Дата відкриття внеску
        protected double depositAmount; // Розмір внеску
        protected double depositInterestRate; // Відсоток по внескові

        public Depositor(string lastName) : base(lastName)
        {
        }

        public void SetDeposit(DateTime openDate, double amount, double interestRate)
        {
            depositOpenDate = openDate;
            depositAmount = amount;
            depositInterestRate = interestRate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Depositor: {lastName}");
            Console.WriteLine($"Deposit Open Date: {depositOpenDate}");
            Console.WriteLine($"Deposit Amount: {depositAmount}");
            Console.WriteLine($"Deposit Interest Rate: {depositInterestRate}");
        }

        public override bool MatchDate(DateTime date)
        {
            return depositOpenDate.Date == date.Date;
        }
    }
}
