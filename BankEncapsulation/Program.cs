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

            var AccountInfo = new PersonalInformation();

            Console.WriteLine("What is your phone number starting with your area code?");
            AccountInfo.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your new phone number is {AccountInfo.NumberFormatted}");

        }
    }
}
