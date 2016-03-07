using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProjectDay {
    class Program {
        static Client bobSaget = new Client();
        static Account bobSagetAccount = new Account(bobSaget.Name);
        static Savings bobSagetSavings = new Savings(bobSaget.Name);
        static Reserve bobSagetReserve = new Reserve(bobSaget.Name);
        static Checking bobSagetChecking = new Checking(bobSaget.Name);
        static Menu menus = new Menu();
        static void Main(string[] args) {
            Menu();
            bobSagetChecking.WriteToFile();
            bobSagetReserve.WriteToFile();
            bobSagetSavings.WriteToFile();
        }

        static void Menu() {
            string[] menu = { "View Client Information", "View Account Balance", "Deposit Funds", "Withdraw Funds", "Exit"};
            string[] menuAccounts = {"Checking", "Reserve", "Savings"};
            Console.WriteLine("\n");
            int counter = 1;
            foreach (string menuItems in menu) {
                Console.WriteLine($"\t{counter}. {menuItems}");
                counter++;
            }
            Console.WriteLine("\nEnter a number to chose a menu item.");
            string menuSelection = Console.ReadLine();
            switch (menuSelection) {
                case "1":
                    menus.ClientInformation(bobSaget.Name, bobSaget.PhoneNumber);
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    int menuCounterBalance = 1;
                    foreach (string menuItems in menuAccounts) {
                        Console.WriteLine($"\t{menuCounterBalance}. {menuItems}");
                        menuCounterBalance++;
                    }
                    Console.WriteLine("\nWhich account balance would you like to see? Enter a number to chose a menu item.");
                    string menuAccountSelection = Console.ReadLine();
                    switch (menuAccountSelection) {
                        case "1":
                            menus.AccountBalance(bobSaget.Name, bobSagetChecking.AccountType, bobSagetChecking.Balance);
                            break;
                        case "2":
                            menus.AccountBalance(bobSaget.Name, bobSagetReserve.AccountType, bobSagetReserve.Balance);
                            break;
                        case "3":
                            menus.AccountBalance(bobSaget.Name, bobSagetSavings.AccountType, bobSagetSavings.Balance);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid selection. Please try again.");
                            Menu();
                            break;
                    }
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    int menuCounterDeposit = 1;
                    foreach (string menuItems in menuAccounts) {
                        Console.WriteLine($"\t{menuCounterDeposit}. {menuItems}");
                        menuCounterDeposit++;
                    }
                    Console.WriteLine("\nWhich account would you like to deposit into? Enter a number to chose a menu item.");
                    string menuAccountDepositSelection = Console.ReadLine();
                    switch (menuAccountDepositSelection) {
                        case "1":
                            bobSagetChecking.Deposit(menus.AccountTransaction("deposit", bobSagetChecking.AccountType));
                            break;
                        case "2":
                            bobSagetReserve.Deposit(menus.AccountTransaction("deposit", bobSagetReserve.AccountType));
                            break;
                        case "3":
                            bobSagetSavings.Deposit(menus.AccountTransaction("deposit", bobSagetSavings.AccountType));
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid selection. Please try again.");
                            Menu();
                            break;
                    }
                    Menu();
                    break;
                case "4":
                    Console.Clear();
                    int menuCounterWithdraw = 1;
                    foreach (string menuItems in menuAccounts) {
                        Console.WriteLine($"\t{menuCounterWithdraw}. {menuItems}");
                        menuCounterWithdraw++;
                    }
                    Console.WriteLine("\nWhich account would you like to deposit into? Enter a number to chose a menu item.");
                    string menuAccountWithdrawSelection = Console.ReadLine();
                    switch (menuAccountWithdrawSelection) {
                        case "1":
                            bobSagetChecking.Withdraw(menus.AccountTransaction("withdraw", bobSagetChecking.AccountType));
                            break;
                        case "2":
                            bobSagetReserve.Withdraw(menus.AccountTransaction("withdraw", bobSagetReserve.AccountType));
                            break;
                        case "3":
                            bobSagetSavings.Withdraw(menus.AccountTransaction("withdraw", bobSagetSavings.AccountType));
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid selection. Please try again.");
                            Menu();
                            break;
                    }
                    Menu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Have a good day!\nPress any key to exit. . . Goodbye!");
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
