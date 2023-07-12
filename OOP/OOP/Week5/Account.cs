using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week5
{
    public class Account
    {
        // Name, Email - Auto implemented Properties
        // Country - Property

        public int MyProperty { get; set; }

        //public Account()
        //{
        //    balance = 100;
        //}

        private double balance;

        public double Balance
        {
            get
            {
                return balance * 10;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance cannot negative.");
                }

                balance = value;
            }
        }

        //public double GetBalance()
        //{
        //    return balance;
        //}

        //public void Withdraw(double money)
        //{
        //    if (balance - money < 0)
        //    {
        //        throw new Exception("Balance cannot negative.");
        //    }

        //    balance = balance - money;
        //}
    }
}
