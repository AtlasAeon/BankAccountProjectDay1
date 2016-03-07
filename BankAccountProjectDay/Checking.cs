using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Checking:Account {
        decimal balance;
        int transactions;

        public Checking(string name) : base (name) {
            this.balance = 20143165m;
            this.accountType = "Checking";
            this.transactions = 0;
            this.accountList.Add($"Client Name: {name}\tAccount Number: {AccountNumber}");
            this.accountList.Add($"{this.accountType} Account");
        }

        public string AccountType {
            get { return this.accountType; }
        }

        public int Transactions {
            get { return this.transactions; }
        }

        new public decimal Balance {
            get { return this.balance; }
        }

        new public void Deposit(string input) {
            if (input == "Error 100") {
                Console.WriteLine("Invalid deposit amount. . .");
            } else if (input == "Error 200") {
                Console.WriteLine("Invalid input. . .");
            } else {
                decimal depositAmount = decimal.Parse(input);
                this.balance = this.balance + depositAmount;
                accountList.Add($"{DateTime.Now} + Transaction amount: {depositAmount} Account Balance: {this.balance}");
            }
            this.transactions++;
        }

        new public void Withdraw(string input) {
            if (input == "Error 100") {
                Console.WriteLine("Invalid deposit amount. . .");
            } else if (input == "Error 200") {
                Console.WriteLine("Invalid input. . .");
            } else {
                decimal withdrawAmount = decimal.Parse(input);
                this.balance = this.balance - withdrawAmount;
                accountList.Add($"{DateTime.Now} - Transaction amount: {withdrawAmount} Account Balance: {this.balance}");
            }
            this.transactions++;
        }
    }
}
