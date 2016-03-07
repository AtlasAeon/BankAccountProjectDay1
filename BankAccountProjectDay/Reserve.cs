using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Reserve:Account {
        decimal balance;
        decimal interest;

        public Reserve(string name) : base(name) {
            this.balance = 2850234m;
            this.interest = 0.003m;
            this.accountType = "Reserve";
            this.accountList.Add($"Client Name: {name}\tAccount Number: {AccountNumber}");
            this.accountList.Add($"{this.accountType} Account");
        }

        new public decimal Balance {
            get { return this.balance; }
        }

        public string AccountType {
            get { return this.accountType; }
        }

        public decimal Interest {
            get { return this.interest; }
        }
    }
}
