using System;
using System.Text;


namespace Bank
{


    //Bank abstract class is a class that cannot be instantiated. 
    //Instead,  here it serves as a base class for savings  classe to inherit from.
    abstract class Account
    {
        public double balance;
        public double ammount;
        public abstract bool Deposit(double amount);

        public abstract bool Withdraw(double amount);


// the protected modifier is used here for bankID
        protected int bankID;
       
        public int BankID()
        {
            return bankID = 3;
        }
    }


}
