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
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);

    }
}
