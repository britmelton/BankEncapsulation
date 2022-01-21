using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount yourAccount = new BankAccount();

            Console.WriteLine("Enter your deposit amount: \n");

            yourAccount.Deposit(double.Parse(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Your new account balance is: \n");
            Console.WriteLine(yourAccount.GetBalance());
            




        }






















        //yourAccount.Deposit(double.Parse(Console.ReadLine())); Console.WriteLine("Or type \"done\" to exit.");
        /*public static void AskIfDone()
        {
            string exit = Console.ReadLine();
            string done = "done";
            if (exit == done.ToLower())
            Environment.Exit(0);

        }*/
    }

}
