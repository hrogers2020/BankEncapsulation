using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var hamptonsAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            hamptonsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {hamptonsAccount.GetBalance()}");
        }
    }
}
