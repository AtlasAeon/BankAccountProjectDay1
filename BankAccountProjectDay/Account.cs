using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Account {
        string accountNumber;
        decimal balance;

        public Account() {
            this.accountNumber = GenerateAccountNumber();
            this.balance = 18598254.23m;
        }

        public decimal Balance {
            get { return this.balance; }
        }

        public string AccountNumber {
            get { return this.accountNumber; }
        }

        public string GenerateAccountNumber() {
            Random rand = new Random();
            StringBuilder generate = new StringBuilder();
            for (int i = 0; i < 7; i++)
                generate.Append(rand.Next(0, 10).ToString());
            return generate.ToString();
        }
        public void Deposit(decimal depositAmount) {
            this.balance = this.balance + depositAmount;
        }

        public void Withdraw(decimal withdrawAmount) {
            this.balance = this.balance - withdrawAmount;
        }
    }
}
