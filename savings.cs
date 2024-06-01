using System;


namespace Bank
{
    class Savings : Account
    {
        public Savings() : base()
        {
        }

        // Members of Savings can access 'bankID' that was earlier declared protected in base class 
        public int getID()
        {
            return bankID =3;
        }
  


        public override bool Deposit(double amount)
        {
            this.ammount = amount;
            this.balance = balance + ammount;

            Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
            return true;
        }

        public override bool Withdraw(double amount)
        {
           Console.WriteLine("The Transaction id initiatied ...... againist ID  " + "  /n" + bankID);

            this.ammount = amount;
            this.balance = balance - ammount;
            Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);
            return true;
        }
    }
}
