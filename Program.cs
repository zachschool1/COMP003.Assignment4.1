using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepCounter = 0;
            char response;
            do
            {
                Console.WriteLine("Pick a choice: ");
                Console.WriteLine("1. Start/Continue");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Choice: ");
                response = Console.ReadKey().KeyChar;
                Console.WriteLine();


                if (response == '3')
                {
                    Console.WriteLine("Exiting Program");
                    break;
                }

                if (response == '1')
                {
                    stepCounter++;
                    Console.WriteLine($"Routine step {stepCounter} completed");
                }
                if (response == '2')
                {
                    Console.WriteLine($"Current progress: {stepCounter} steps completed.");
                }
            } 
            while (true);

        }
    }
}
