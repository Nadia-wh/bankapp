using System;


namespace Bank 
{
    class Bank 
    {
        // this class bank is dedicated to store and check the bank info of a single person 
        //assuming one person has created an account and bank ID has been allocated
        public string myName ="Anne";
        public double myBalance = 0 ;
        protected int  bankID = 33;


        
        //this class  can be used to create an account(later) 
        //and display the information 
        
        public void showInfo()
        {
                Console.WriteLine("Your details: ");
                Console.WriteLine("Name: "+myName);
                Console.WriteLine("Balance: " +myBalance);
                Console.WriteLine("bank id is " + bankID) ;

        }

    }    
}