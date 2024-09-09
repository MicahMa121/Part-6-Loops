namespace Part_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Hello, please enter the program you would like to use!");
                Console.WriteLine("1.Prompter 2.Simple Banking Machine 3.Double Roller ");
            }
            while (int.TryParse(Console.ReadLine(), out option));
            switch (option)
            {
                case 1:
                    Prompter();
                    break;
            }
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
            if (!int.TryParse(Console.ReadLine(), out max)||min >= max)
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
                return;
            }
            int input;
            do
            {
                Console.WriteLine("Please enter a number between "+min +","+max);

            }
            while(int.TryParse(Console.ReadLine(),
        }
    }
}
