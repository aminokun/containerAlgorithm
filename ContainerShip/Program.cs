namespace containership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;



            Console.WriteLine("Please provide the length of the ship: ");
            if (args.Length == 0)
            {
                bool validLength = false;
                while (!validLength)
                {
                    if (int.TryParse(Console.ReadLine(), out length))
                    {
                        validLength = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for length. Please enter a valid integer.");
                    }
                }

                Console.WriteLine("Please provide the width of the ship: ");
                bool validWidth = false;
                while (!validWidth)
                {
                    if (int.TryParse(Console.ReadLine(), out width))
                    {
                        validWidth = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for width. Please enter a valid integer.");
                    }
                }
            }


            Ship ship = new Ship(length, width);
            Console.WriteLine(ship.ToString());

        }
    }
}