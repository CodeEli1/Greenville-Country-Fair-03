using System;

class Program
{
    static void Main(string[] args)
    {
        const int ticketPrice = 25;
        bool exitProgram = false;

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        while (!exitProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    int lastYearContestants;
                    int thisYearContestants;

                    Console.Write("Enter the number of contestants last year (0 to 30): ");
                    while (!int.TryParse(Console.ReadLine(), out lastYearContestants) || lastYearContestants < 0 || lastYearContestants > 30)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of contestants between 0 and 30.");
                        Console.Write("Enter the number of contestants last year (0 to 30): ");
                    }

                    Console.Write("Enter the number of contestants this year (0 to 30): ");
                    while (!int.TryParse(Console.ReadLine(), out thisYearContestants) || thisYearContestants < 0 || thisYearContestants > 30)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of contestants between 0 and 30.");
                        Console.Write("Enter the number of contestants this year (0 to 30): ");
                    }

                    int revenue = thisYearContestants * ticketPrice;
                    string competitionMessage;

                    if (thisYearContestants > 2 * lastYearContestants)
                    {
                        competitionMessage = "The competition is more than twice as big this year!";
                    }
                    else if (thisYearContestants > lastYearContestants)
                    {
                        competitionMessage = "The competition is bigger than ever!";
                    }
                    else
                    {
                        competitionMessage = "A tighter race this year! Come out and cast your vote!";
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
                    Console.WriteLine($"Revenue expected this year is ${revenue}");
                    Console.WriteLine(competitionMessage);
                    break;

                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    break;
            }
        }
    }
}