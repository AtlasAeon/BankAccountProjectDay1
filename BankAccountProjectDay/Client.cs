using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Client {
        string name;
        string phoneNumber;

        public Client() {
            this.name = "Bob Saget";
            this.phoneNumber = "555 555-2432";
        }

        public string GetPhoneNumber() {
            return this.phoneNumber;
        }

        public string Name {
            get { return this.name; }
        }

        public string PhoneNumber {
            get { return this.phoneNumber; }
        }
    }
}
