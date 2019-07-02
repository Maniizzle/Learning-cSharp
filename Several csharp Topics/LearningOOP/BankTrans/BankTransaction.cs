using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    class BankTransaction
    {
        public string AccountFullName { get; set; }
        public int AccountNumber { get; set; }
        public string RecipentFullName { get; set; }
       public DateTime Date { get;}
        public int RecipentAccountNumber { get; set; }
        public decimal CurrentBalance { get; }
        public string Location { get; set; }





        public  BankTransaction(int accountNumber, 
            string fullname, string location,string accountName,string recipentFullName,int recipentAcntNumber)
        {

            Location = location;
            AccountNumber = accountNumber;
            RecipentFullName = recipentFullName;
            RecipentAccountNumber = recipentAcntNumber;

            
        }
             
             
             
             
            

        public void AirtimeSelf(int amount, int pin)
        {
            Console.WriteLine($"{amount} has been credited to your Line ");
        }

        public void Deposit()
        {

        }

        public void Withdraw(int accountNumber, decimal amount)
        {

        }
    }
}
