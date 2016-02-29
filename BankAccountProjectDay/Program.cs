using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProjectDay {
    class Program {
        static Client bobSaget = new Client();
        static Account bobSagetAccount = new Account();
        static List<string> accountSummaryList = new List<string>();
        static void Main(string[] args) {
            bobSagetAccount.GenerateAccountNumber();
            accountSummaryList.Add($"Client Name: {bobSaget.Name}\tAccount Number: {bobSagetAccount.AccountNumber}");
            Menu();
            using(StreamWriter accountInfoFile = new StreamWriter("AccountSummary.txt")) {
                foreach (string items in accountSummaryList)
                    accountInfoFile.WriteLine(items);
            }
        }

        static void ClientInformation() {
            Console.Clear();
            Console.WriteLine($"Client name: {bobSaget.Name}\nClient Phone Number: {bobSaget.PhoneNumber}");
            Menu();
        }

        static void AccountBalance() {
            Console.Clear();
            Console.WriteLine($"{bobSaget.Name}'s Balance: {bobSagetAccount.Balance}");
            Menu();
        }

        static void AccountDeposit() {
            Console.Clear();
            Console.WriteLine("Please enter the amount you want to deposit.");
            string userInput = Console.ReadLine();
            decimal depositAmount;
            bool result = decimal.TryParse(userInput, out depositAmount);
            if (result) {
                bobSagetAccount.Deposit(depositAmount);
                StringBuilder accountLineBuilder = new StringBuilder();
                accountLineBuilder.Append($"{DateTime.Now} + Transaction amount: {depositAmount} Account Balance: {bobSagetAccount.Balance}");
                accountSummaryList.Add(accountLineBuilder.ToString());
            } else {
                Console.Clear();
                Console.WriteLine("Invalid input. . .");
            }
            Menu();
        }

        static void AccountWithdraw() {
            Console.Clear();
            Console.WriteLine("Please enter the amount you want to withdraw.");
            string userInput = Console.ReadLine();
            decimal withdrawAmount;
            bool result = decimal.TryParse(userInput, out withdrawAmount);
            if (result) {
                if(withdrawAmount > bobSagetAccount.Balance) {
                    Console.Clear();
                    Console.WriteLine("This amount exceeds your account balance.");
                } else {
                    bobSagetAccount.Withdraw(withdrawAmount);
                    StringBuilder accountLineBuilder = new StringBuilder();
                    accountLineBuilder.Append($"{DateTime.Now} - Transaction amount: {withdrawAmount} Account Balance: {bobSagetAccount.Balance}");
                    accountSummaryList.Add(accountLineBuilder.ToString());
                }
            } else {
                Console.Clear();
                Console.WriteLine("Invalid input. . .");
            }
            Menu();
        }

        static void Menu() {
            int counter = 1;
            string[] menu = { "View Client Information", "View Account Balance", "Deposit Funds", "Withdraw Funds", "Exit"};
            Console.WriteLine("\n");
            foreach (string menuItems in menu) {
                Console.WriteLine($"\t{counter}. {menuItems}");
                counter++;
            }
            Console.WriteLine("\nEnter a number to chose a menu item.");
            string menuSelection = Console.ReadLine();
            switch (menuSelection) {
                case "1":
                    ClientInformation();
                    break;
                case "2":
                    AccountBalance();
                    break;
                case "3":
                    AccountDeposit();
                    break;
                case "4":
                    AccountWithdraw();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Have a good day!\nGoodbye");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Please try again.");
                    Menu();
                    break;
            }
        }
    }
}
