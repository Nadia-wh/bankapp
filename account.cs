using System;
using System.Text;


namespace Bank
{
    abstract class Account
    {
        public double balance;
        public double ammount;
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);



        


    }
}