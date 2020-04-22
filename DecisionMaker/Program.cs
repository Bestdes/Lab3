using System;
using System.Reflection.Metadata.Ecma335;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean reRun = true;
            Boolean handleInvalid = true;
            Boolean runIntro = true;
            string userName = "";



            while (reRun)
            {
                while (runIntro)
                {
                    Console.WriteLine("Hello welcome to the Grand Circus Decision Maker. Please enter your name");
                    userName = Console.ReadLine();
                    runIntro = false;
                }

                Console.WriteLine($"Please enter a number so the decision maker can process: ");

                string input = Console.ReadLine();

                try
                {
                    int userNum = int.Parse(input);

                    if (userNum > 0 && userNum < 101)
                    {

                        if (userNum % 2 == 0)
                        {
                            if (userNum >= 2 && userNum < 26)
                            {
                                Console.WriteLine($"{userName} you entered a number that is: Even and less than 25");
                            }
                            else if (userNum >= 26)
                            {
                                Console.WriteLine($"{userName} you entered a number that is: Even");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{userName} you entered a number that is: Odd");
                        }

                        handleInvalid = true;

                        while (handleInvalid)
                        {
                            Console.WriteLine($"Do you want to run the decision maker again, {userName}? (y/n)");
                            String reRunInput = Console.ReadLine();
                            if (reRunInput == "y")
                            {
                                runIntro = true;
                                handleInvalid = false;
                            }
                            else if (reRunInput == "n")
                            {
                                Console.WriteLine($"Thank you for using the Grand Circus Decision Maker, {userName}.");
                                reRun = false;
                                handleInvalid = false;
                            }
                            else
                            {
                                Console.WriteLine($"Invalid input try again, {userName}.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number is out of range! Please enter a number between 1 and 100");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Format error. Please enter in a valid number!");
                }
            
            }
        }
    }
}
