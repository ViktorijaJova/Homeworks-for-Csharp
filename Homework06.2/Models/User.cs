using System;
using System.Collections.Generic;
using System.Text;

namespace Homework06.App.Models
{
    public class User
    {
        public string Username { get; set; }
        public long CardNumber { get; set; }
        private string Pin { get; set; }
        private double Balance;

        public User(string username, long cardNumber, string pin, double balance)
        {
            CardNumber = cardNumber;
            Username = username;
            Pin = pin;
            Balance = balance;
        }

        public void CashWithdraw(double sum)
        {
            Balance -= sum;
        }
        public void CashDeposit(double sum)
        {
            Balance += sum;
        }
        public double GetBalance()
        {
            return Balance;
        }

        public string GetPin()
        {
            return Pin;
        }

    }

}
