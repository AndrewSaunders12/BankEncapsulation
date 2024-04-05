namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How would you like to continue /Deposit /Withdraw /Check Balance");
            string userInput = Console.ReadLine();
            account.Pin();



            if (userInput == "Balance")
            {
                account.GetBalance();
            }
            if (userInput == "Withdraw")
            {
                account.Withdraw(); 
            }
            if (userInput == "Deposit")
            {
                account.Deposit();
            }










        }
    }
}
