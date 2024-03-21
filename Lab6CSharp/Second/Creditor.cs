using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.Second
{
    internal class Creditor : Client, ICreditor
    {
        protected DateTime loanIssueDate; // Дата видачі кредиту
        protected double loanAmount; // Розмір кредиту
        protected double loanInterestRate; // Відсоток по кредиту
        protected double remainingLoanBalance; // Остача боргу

        public Creditor(string lastName) : base(lastName)
        {
        }

        public void SetLoan(DateTime issueDate, double amount, double interestRate, double remainingBalance)
        {
            loanIssueDate = issueDate;
            loanAmount = amount;
            loanInterestRate = interestRate;
            remainingLoanBalance = remainingBalance;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Creditor: {lastName}");
            Console.WriteLine($"Loan Issue Date: {loanIssueDate}");
            Console.WriteLine($"Loan Amount: {loanAmount}");
            Console.WriteLine($"Loan Interest Rate: {loanInterestRate}");
            Console.WriteLine($"Remaining Loan Balance: {remainingLoanBalance}");
        }

        public override bool MatchDate(DateTime date)
        {
            return loanIssueDate.Date == date.Date;
        }
    }
}
