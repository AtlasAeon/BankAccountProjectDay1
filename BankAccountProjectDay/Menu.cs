using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjectDay {
    class Menu {
        public void ClientInformation(string name, string phoneNumber) {
            Console.Clear();
            Console.WriteLine($"Client name: {name}\nClient Phone Number: {phoneNumber}");
        }

        public void AccountBalance(string name, string accountType, decimal balance) {
            Console.Clear();
            Console.WriteLine($"{name}'s {accountType} Balance: {balance}");
        }

        public string AccountTransaction(string transactionType, string accountType) {
            Console.Clear();
            Console.WriteLine($"Please enter the amount you want to {transactionType} into {accountType}.");
            string userInput = Console.ReadLine();
            decimal transactionAmount;
            bool result = decimal.TryParse(userInput, out transactionAmount);
            if (result) {
                if (transactionAmount <= 0) {
                    return "Error 100";
                } else {
                    if (transactionType == "Deposit")
                        Console.WriteLine($"You deposited {transactionAmount} into {accountType}");
                    else
                        Console.WriteLine($"You withdrew {transactionAmount} from {accountType}");
                    return userInput;
                }
            } else {
                return "Error 200";
            }
        }
    }
}
