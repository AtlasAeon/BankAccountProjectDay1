using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProjectDay {
    class Account {
        string accountNumber;
        private decimal balance;
        protected string accountType;
        protected List<string> accountList = new List<string>();
        StringBuilder accountBuilder = new StringBuilder();

        public Account(string name) {
            this.accountNumber = GenerateAccountNumber();
            this.balance = 18598254.23m;
            this.accountType = "Account";
            //this.accountList.Add($"Client Name: {name}\tAccount Number: {AccountNumber}");
            //this.accountList.Add($"{this.accountType} Account");
        }

        public decimal Balance {
            get { return this.balance; }
        }

        public string AccountNumber {
            get { return this.accountNumber; }
        }

        public void WriteToFile() {
            using (StreamWriter accountWriter = new StreamWriter($"{this.accountType}Summary.txt")) {
                foreach (string items in this.accountList)
                    accountWriter.WriteLine(items);
            }
        }

        public string GenerateAccountNumber() {
            Random rand = new Random();
            StringBuilder generate = new StringBuilder();
            for (int i = 0; i < 7; i++)
                generate.Append(rand.Next(0, 10).ToString());
            return generate.ToString();
        }
        public void Deposit(string input) {
            if (input == "Error 100") {
                Console.WriteLine("Invalid deposit amount. . .");
            } else if (input == "Error 200") {
                Console.WriteLine("Invalid input. . .");
            } else {
                decimal depositAmount = decimal.Parse(input);
                this.balance = this.balance + depositAmount;
                accountList.Add($"{DateTime.Now} + Transaction amount: {depositAmount} Account Balance: {this.balance}");
            }
        }

        public void Withdraw(string input) {
            if (input == "Error 100") {
                Console.WriteLine("Invalid deposit amount. . .");
            } else if (input == "Error 200") {
                Console.WriteLine("Invalid input. . .");
            } else {
                decimal withdrawAmount = decimal.Parse(input);
                this.balance = this.balance - withdrawAmount;
                accountList.Add($"{DateTime.Now} - Transaction amount: {withdrawAmount} Account Balance: {this.balance}");
            }
        }
    }
}
