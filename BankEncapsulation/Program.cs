using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much do you want to Deposit?");
            var depoAmount = double.Parse(Console.ReadLine());
            account.Deposit(depoAmount);
            Console.WriteLine($"Your new balance is {account.GetBalance()}");
        }
    }
}
