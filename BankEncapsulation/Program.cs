using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount BankAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            BankAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you. Your balance is now {BankAccount.GetBalance()}");
        }
    }
}
