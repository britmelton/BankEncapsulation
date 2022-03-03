using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bank Encapsulation Exercise Instructions
            /*Create a new Console Application it BankEncapsulation
             * Create a new public class named BankAccount
             * In your BankAccount class, create the following:
             * A private field of type double named balance with a value of 0
             * Define a method named Deposit that will accept a double and store that value in the balance field
             * Define a method named GetBalance that will return the amount stored in the balance field 
             * In the main method of your application, create a new instance of the BankAccount class.  
             * Allow the user of the application to Deposit money and retrieve their balance through the console.*/
            #endregion

            Console.WriteLine("Welcome to Your Bank!");

            BankAccount yourAccount = new BankAccount();

            do
            {
                Console.WriteLine("\nEnter your deposit amount: ");
                Console.WriteLine("or enter \"done\" to exit\n");
                string str = Console.ReadLine();
                if (str == "done")
                    break;
                int x = Convert.ToInt32(str);
                yourAccount.Deposit(x);
                Console.Clear();
                Console.WriteLine("\nYour new account balance is: \n");
                Console.WriteLine(yourAccount.GetBalance());
            }while(true);
        }
    }

}
