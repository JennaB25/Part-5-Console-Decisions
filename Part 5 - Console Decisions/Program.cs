using System.Globalization;
using System.Security.Cryptography;
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
            if (Int32.TryParse(input, out int result))
            {
                int _input = Convert.ToInt32(input);
                switch (_input)
                {
                    case 1:
                        Console.Clear();
                        bankingMachine();
                        break;
                    case 2:
                        Console.Clear();
                        parkingGarage();
                        break;
                    case 3:
                        Console.Clear();
                        hurricane();
                        break;
                    default:
                        Console.WriteLine("Error: Run Program Again");
                        break;
                }

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
                if (Int32.TryParse(amount, out int result))
                {
                    int _amount = Convert.ToInt32(amount);
                    Console.WriteLine($"Remaining Balance in Account: ${balance + _amount}");
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again.");
                }   
                
            }
            else if (inputTwo == withdrawal)
            {
                Console.WriteLine("Enter the amount you wish to withdrawal:");
                string amount = Console.ReadLine();
                amount = amount.Replace("$", "");
                if (Int32.TryParse(amount, out int result))
                {
                    int _amount = Convert.ToInt32(amount);
                    if (_amount >= balance)
                    {
                        Console.WriteLine("Error: Insufficent Funds");
                    }
                    else
                    {
                        Console.WriteLine($"Remaining Balance in Account: ${balance - _amount}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again.");
                }
                
            }
            else if (inputTwo == billPayment)
            {
                Console.WriteLine("Enter the amount you wish to pay:");
                string amount = Console.ReadLine();
                amount = amount.Replace("$", "");
                if (Int32.TryParse(amount, out int result))
                {
                    int _amount = Convert.ToInt32(amount);
                    if (_amount >= balance)
                    {
                        Console.WriteLine("Error: Insufficent Funds");
                    }
                    else
                    {
                        Console.WriteLine($"Remaining Balance in Account: ${balance - _amount}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again.");
                }
                
            }
            else if (inputTwo == balanceUpdate)
            {
                Console.WriteLine("Press Enter to see your balance:");
                Console.ReadLine();
                Console.WriteLine($"Remaining Balance in Account: ${balance}");
            }
            else
            {
                Console.WriteLine("Error: Run Program Again.");
            }

        }
        public static void parkingGarage()
        {
            double amount;
            double hours;
            Console.WriteLine("Enter the number of minutes your car was parked for:");
            string minutes = Console.ReadLine();
            minutes = minutes.Replace("mins", "");
            if (Int32.TryParse(minutes, out int result))
            {
                double _minutes = Convert.ToDouble(minutes);
                hours = _minutes / 60;
                if (_minutes <= 60)
                {
                    hours = Math.Ceiling(hours);
                    amount = 4.00;
                    Console.WriteLine($"You stayed for {hours}hrs and your fee is ${amount}");
                }
                else if (_minutes >= 60)
                {
                    hours = Math.Ceiling(hours);
                    amount = ((hours - 1) * 2.00) + 4.00;
                    if (amount >= 20.00)
                    {
                        Console.WriteLine("Max fee reached");
                        Console.WriteLine($"You stayed for {hours}hrs and your fee is ${20}");
                    }
                    else
                    {
                        Console.WriteLine($"You stayed for {hours}hrs and your fee is ${amount}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again.");
                }
            }
            else
            {
                Console.WriteLine("Error: Run Program Again.");
            }
            
        }
        public static void hurricane()
        {
            Console.WriteLine("Enter a hurricane cattegory from 1 to 5 to get the wind speeds:");
            string hurricaneLevel = Console.ReadLine();
            if (Int32.TryParse(hurricaneLevel, out int result))
            {
                int _hurricaneLevel = Convert.ToInt32(hurricaneLevel);
                switch (_hurricaneLevel)
                {
                    case 1:
                        Console.WriteLine("Wind Speed: 74-95mph or 64-82kt or 119-153km/hr");
                        break;
                    case 2:
                        Console.WriteLine("Wind Speed: 96-110mph or 83-95kt or 154-177km/hr");
                        break;
                    case 3:
                        Console.WriteLine("Wind Speed: 111-130mph or 83-95kt or 178-209km/hr");
                        break;
                    case 4:
                        Console.WriteLine("Wind Speed: 131-155mph or 114-135kt or 210-249km/hr");
                        break;
                    case 5:
                        Console.WriteLine("Wind Speed: Greater than 155 mph or 135kt or 249km/hr");
                        break;
                    default:
                        Console.WriteLine("Error: Run Program Again");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Run Program Again");
            }
        }
    }
}