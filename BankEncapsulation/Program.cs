namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How would you like to continue\n Deposit\t Withdraw\t Check Balance");
            string userInput = Console.ReadLine();
            account.Pin();
            


            if (userInput.ToLower() == "balance")
            {
                account.GetBalance();
            }
            if (userInput.ToLower() == "withdraw")
            {
                account.Withdraw(); 
            }
            if (userInput.ToLower() == "deposit")
            {
                account.Deposit();
            }










        }
    }
}
