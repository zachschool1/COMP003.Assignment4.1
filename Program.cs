using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepCounter = 0;
            string response;
            do
            {
                Console.WriteLine("Pick a choice: ");
                Console.WriteLine("1. Start/Continue");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Choice: ");
                response = Console.ReadLine();
                Console.WriteLine();


                if (response == "3")
                {
                    Console.WriteLine("Exiting Program");
                    break;
                } else if (response == "1")
                {
                    if (stepCounter == 5)
                    {
                        Console.WriteLine("RESTRICTED STEP. SKIPPED.");
                        stepCounter++;

                    } else
                    {
                        stepCounter++;
                        Console.WriteLine($"Routine step {stepCounter} completed");
                    }
                    
                    
                } else if (response == "2")
                {
                    Console.WriteLine($"Current progress: {stepCounter} steps completed.");
                } else
                {
                    Console.WriteLine("Invalid Input");
                    
                }

                
            } 
            while (true);

        }
    }
}
