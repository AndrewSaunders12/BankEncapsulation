using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;

        public double Deposit()
        {

            Console.WriteLine("How much do you want to deposit");
            var amount = double.Parse(Console.ReadLine());
            Console.WriteLine($"_balance + {amount}");
            _balance = _balance + amount;
            Console.WriteLine(_balance);
            return _balance;
        }

        public double GetBalance()
        {
            Console.WriteLine($"Balance; {_balance}");
            return _balance;
        }

        public double Withdraw()
        {
            Console.WriteLine("How much do you want to withdraw");
            var amount = double.Parse(Console.ReadLine());
            Console.WriteLine($"Withdrawl Amount: -{amount}");
            _balance = _balance - amount;
            Console.WriteLine(_balance);
            return _balance;
        }

        public bool Pin()
        {

            Console.WriteLine("Please enter your pin");
            var number = int.Parse(Console.ReadLine());

            if (number == 4321)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Pin");
                Pin();
                return false;
            }



        }


    }
}
