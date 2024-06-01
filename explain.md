Assignments - Object Oriented Programming 
# Assignments - Object Oriented Programming

Assume you are implementing a Banking Application. Identify entities in the system. Create classes and methods for the various operations in a Bank.

* Use necessary access modifiers and encapsulation techniques to protect the data.
* Use constructors to initialize the objects.
* Use inheritance to create a hierarchy of classes.
* Use abstract classes where necessary.
* Simulate some transactions in the application.
  
## Entities and Classes

![image](https://github.com/Nadia-wh/bankapp/assets/64726301/ad220c8e-7e52-4bdc-8ac2-42b0e5163318)


## Deciding Entities

We first decide the entities that we are going to have in our diagram :

Bank
Account 
Customer
Transaction

## We then decide what attributes are associated with these entities:

Bank: Name
Account: Balance,holdername
Customer: Name
Transaction: Deposit Account, Withdrawal Account

## Deciding Relationships  

We then decide the relationships between the various entities:
A Bank Account is owned by a Customer.
A Bank has a Bank Account.
A Transaction is linked to the Bank Account. 
The relationship between Bank Account and Customer is many to one because a Customer can have many Bank Accounts.
The relationship between Bank and Bank Account is one too many as a Bank has many bank accounts. 
The Transaction to bank account relationship is many to one because multiple transitions can be linked to one bank account.


## Classes accordingly has been designed as 
BANK CLASS :
ACCOUNT CLASS :
TRANSACTION CLASS ;
MAIN CLASS (program.cs)

## MAIN FILE (program.cs)

`
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
`

### SNAPSHOTS

![Screenshot (88)](https://github.com/Nadia-wh/bankapp/assets/64726301/b2ba461f-f576-48b5-8dd5-1e67230baadd)
![Screenshot (96)](https://github.com/Nadia-wh/bankapp/assets/64726301/f63385c5-6b9c-4570-b6f2-b727db62e867)
![Screenshot (95)](https://github.com/Nadia-wh/bankapp/assets/64726301/57896192-a18f-4a9f-864a-0b38ad58a436)
![Screenshot (94)](https://github.com/Nadia-wh/bankapp/assets/64726301/b3dede67-8362-4c43-965f-afe553399153)
![Screenshot (93)](https://github.com/Nadia-wh/bankapp/assets/64726301/5f893cf6-1dd5-4b86-9e88-060f8350e91b)
![Screenshot (89)](https://github.com/Nadia-wh/bankapp/assets/64726301/8e8153bc-b29e-48fb-86e1-99d1284faa6b)
![Screenshot (90)](https://github.com/Nadia-wh/bankapp/assets/64726301/b6da2403-da3b-43ca-aaae-8d1e26930de7)
![Screenshot (92)](https://github.com/Nadia-wh/bankapp/assets/64726301/42c9f4ed-656a-4529-b51e-e8465acc2762)
![Screenshot (91)](https://github.com/Nadia-wh/bankapp/assets/64726301/3ffa6f4c-b281-4b18-bf01-0892b4bc2a9e)






