using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Part_5___Console_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a program:");
            Console.WriteLine("1: Simple Banking Machine");
            Console.WriteLine("2: Parking Garage Cost");
            Console.WriteLine("3: Hurricane");
            string input = Console.ReadLine();
            int one = 1;
            if (Int32.TryParse(input, out one))       
            {
                Console.Clear();
                bankingMachine();
            }
            else
            {
                Console.WriteLine("Error: Run Program Again");
            }
        }
        public static void bankingMachine()
        {
            double balance = 150;
            balance = balance - 0.75;
            string inputTwo;
            string deposit = "DEPOSIT";
            string withdrawal = "WITHDRAWAL";
            string billPayment = "BILL PAYMENT";
            string balanceUpdate = "BALANCE UPDATE";
            Console.WriteLine("Pick One:");
            Console.WriteLine("(Deposit)   (Withdrawal)   (Bill payment)   (Balance update)");
            inputTwo = Console.ReadLine().ToUpper();           
            if (inputTwo == deposit)
            {
                Console.WriteLine("Enter the amount you wish to deposit:");
                string amount = Console.ReadLine();          
                amount = amount.Replace("$", "");
                int _amount = Convert.ToInt32(amount);
                Console.WriteLine($"Remaining Balance in Account: ${balance + _amount}");
            }
            else if (inputTwo == withdrawal)
            {
                Console.WriteLine("Enter the amount you wish to withdrawal:");
                string amount = Console.ReadLine();
                amount = amount.Replace("$", "");
                int _amount = Convert.ToInt32(amount);
                Console.WriteLine($"Remaining Balance in Account: ${balance - _amount}");
            }
            else if (inputTwo == billPayment)
            {
                Console.WriteLine("Enter the amount you wish to pay:");
                string amount = Console.ReadLine();
                amount = amount.Replace("$", "");
                int _amount = Convert.ToInt32(amount);
                //Console.WriteLine($"Remaining Balance in Account: ${balance - _amount}");
            }
            else if (inputTwo == balanceUpdate)
            {
                Console.WriteLine("Press Enter to see your balance:");
                string amount = Console.ReadLine();
                amount = amount.Replace("$", "");
                int _amount = Convert.ToInt32(amount);
                Console.WriteLine($"Remaining Balance in Account: ${balance}");
            }
            else
            {
                Console.WriteLine("Error: Run Program Again.");
            }


        }
        
    }
}