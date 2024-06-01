using System;


namespace Bank 
{
    class Bank 
    {
        // this class bank is dedicated to store and check the bank info of a single person 
        //assuming one person has created an account and bank ID has been allocated
         //this class  can be used to create an account(later) 
        //and display the information 
        public string myName ="Anne";
        public double myBalance = 0 ;

        // a private access modifier is used to save the password 
        private string password ="acccount.txt";



        public void showInfo()
        {
                Console.WriteLine("This is who you are and your balance is : ");
                Console.WriteLine("Name: "+myName);
                Console.WriteLine("Balance: " +myBalance);

        }

    }    
}
