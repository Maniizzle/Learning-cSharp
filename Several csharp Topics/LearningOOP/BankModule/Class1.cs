using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.BankModule
{
    class BankTransaction
    {

        // private string FullName;
        private string AccountName;
        private int AccountNumber;
        private string RecipentName;
        private decimal Amount;
        private DateTime Date;
        private int MobileNumber;

        public string FullName { get; set; }
        public void SetRecipentName(string recipentName)
        {
            RecipentName = recipentName;
        }
        public string GetRecipentName()
        {
            return RecipentName;
        }

        public string Location { get; set; }
        public string OtherBankName
        {
            set
            {
               OtherBankName= value;
            }

        }

        public void SetAccountName(string accountName)
        {
            AccountName = accountName;
        }
        public decimal Deposit()
        {
            
            return 0;
        }

        public decimal Withdraw()
        {
            return 0;
        }
        public decimal Transfer()
        {
            return 0;
        }

        public void AirtimeSelf(int amount,int pin)
        {
            
            Console.WriteLine($"Your number has been credited with {Amount}" );
        }
    }
}
