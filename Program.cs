namespace Part_6_Loops
{
    internal class Program
    {
        static double balance = 150;
        static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
                int option;
                do
                {
                    Console.WriteLine("Hello, please enter the program you would like to use!");
                    Console.WriteLine("1.Prompter 2.Simple Banking Machine 3.Double Roller ");
                }
                while (!int.TryParse(Console.ReadLine(), out option));
                switch (option)
                {
                    case 1:
                        Prompter();
                        break;
                        case 2:
                        Banking(); break;
                        case 3:
                        Roller(); break;
                }
                Console.WriteLine("ENTER to continue, type \"Quit\" to exit");
            }
            while (Console.ReadLine() != "Quit");
            
        }
        public static void Banking()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bank of Blorb! Your current bank account balance is " + balance.ToString("$0.00") + "!(Transaction Fee: $0.75)");
                Console.WriteLine("Available transactions services: \"Deposit\" \"Withdrawal\" \"Bill Payment\" \"Account Balance Update\"");
                Console.WriteLine("Please type in the transaction you wish to transact!(\"Quit\" to exit the Menu)");
                string input = Console.ReadLine();
                if (input == "Deposit")
                {
                    balance = balance -0.75;
                    Console.WriteLine("Please enter the amount of money you would like to deposit!");
                    double amount;
                    if (!double.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.WriteLine("Input Error");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                    else
                    {
                        balance = balance + amount;
                        Console.WriteLine("Transaction Successful!");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                }
                else if (input == "Withdrawal")
                {
                    balance = balance - 0.75;
                    Console.WriteLine("Please enter the amount of money you would like to withdraw!");
                    double amount;
                    if (!double.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.WriteLine("Input Error");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                    else if (amount > balance)
                    {
                        Console.WriteLine("Not Enough Money");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                    else
                    {
                        balance = -amount;
                        Console.WriteLine("Transaction Successful!");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                }
                else if (input == "Bill Payment")
                {
                    balance = balance - 0.75;
                    Console.WriteLine("Please enter the amount of money you would like to pay!");
                    double amount;
                    if (!double.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.WriteLine("Input Error");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                    else if (amount > balance)
                    {
                        Console.WriteLine("Not Enough Money");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                    else
                    {
                        balance = balance - amount;
                        Console.WriteLine("Transaction Successful!");
                        Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                    }
                }
                else if (input == "Account Balance Update")
                {
                    balance = balance - 0.75;
                    Console.WriteLine("Your current bank account balance is " + balance.ToString("$0.00") + "!");
                }
                else
                {
                    Console.WriteLine("Input Error");
                }
                Console.WriteLine("ENTER to return to the menu, type \"Quit\" to exit");
            }
            while (Console.ReadLine() != "Quit");
        }
        public static void Roller()
        {

        }
        public static void Prompter()
        {
            int min, max;
            Console.WriteLine("Please enter a minimum!(integer)");
            if (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please enter a maximum!(integer)");
            if (!int.TryParse(Console.ReadLine(), out max)||min > max)
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
                return;
            }
            int input;
            do
            {
                Console.WriteLine("Please enter a number between "+min +","+max+"(inclusive)");

            }
            while(!int.TryParse(Console.ReadLine(),out input)||input < min||input>max);
            Console.WriteLine(input + " is between " + min + "," + max + "(inclusive)");

        }

    }
}
