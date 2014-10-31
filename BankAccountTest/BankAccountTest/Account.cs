using System;

namespace BankAccountTest
{
    public class Account
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public Account(string accountNo, string customerName):this()
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }

        public Account()
        {
        }
        public double Deposit(double amount)
        {
           return Balance+=amount;
        }

        public double WithDraw(double amount)
        {
            return Balance-=amount;
        }
    }
}