
﻿using System;
using System.Text;

namespace Bank
{
    class Program 
    {
        static void Main(string[] args)
        {
              
            String input;
            Savings sv = new Savings();
            Bank bn = new Bank();
            
            Console.WriteLine("****  Welcome to Bank Management System  ***");
            while (true)
            {
                Console.WriteLine("What you want to do:");
                Console.WriteLine("1. Show account information");
                Console.WriteLine("2. Deposit from account");
                Console.WriteLine("3. Withdraw from account");
                Console.WriteLine("5. to clear");
                Console.WriteLine("6.To exit");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);

                //for 0-6  funtion calling
               
                 if (input == "1")
                {
                   
                    bn.showInfo();
                }
                else if (input == "2")
                {
                    Console.WriteLine("enter the amount to deposit   ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    //using the protected member
                    Console.WriteLine("Transaction started against ID  " + sv.getID());

                     sv.Deposit(a);
                }
                else if (input == "3") 
                {
                  
                    Console.WriteLine("enter the amount to withdraw    ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    sv.Withdraw(a);
                }
                
                else if (input == "5")
                {
                    Console.Clear();
                }
                else if (input == "6")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();

            }

        }

    }
}
