using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Savings:Account {
        decimal balance;
        decimal interest;

        public Savings(string name) : base(name) {
            this.balance = 12231232.03m;
            this.interest = 0.0085m;
            this.accountType = "Savings";
            this.accountList.Add($"Client Name: {name}\tAccount Number: {AccountNumber}");
            this.accountList.Add($"{this.accountType} Account");
        }

        new public decimal Balance {
            get { return this.balance; }
        }

        public decimal Interest {
            get { return this.interest; }
        }

        public string AccountType {
            get { return this.accountType; }
        }
    }
}
