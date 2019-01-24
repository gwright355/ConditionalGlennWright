using System;
// Programmer: Glenn Wright
// conditional statements
// 1/24/2019

namespace ConditionalGlennWright
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write line for user to enter grade the expect to earn in this class
            Console.WriteLine("Please enter the grade you expect to earn in Ism 4300");
            try // Try statement to validate user input
            {
                //This will collect the user input
                String input = Console.ReadLine();

                // This variable will be used to store value of average
                int Average = int.Parse(input);


                if ((Average >= 98) && (Average <= 100))
                {
                    Console.WriteLine("Your grade will be an A+ in the class.");
                    Console.ReadKey(true);
                }

                if ((Average >= 92) && (Average <= 97))
                {
                    Console.WriteLine("Your grade will be an A in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 90) && (Average <= 91))
                {
                    Console.WriteLine("Your grade will be an A- in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 88) && (Average <= 89))
                {
                    Console.WriteLine("Your grade will be a B+ in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 82) && (Average <= 87))
                {
                    Console.WriteLine("Your grade will be a B in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 80) && (Average <= 81))
                {
                    Console.WriteLine("Your grade will be a B- in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 78) && (Average <= 79))
                {
                    Console.WriteLine("Your grade will be a C+ in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 72) && (Average <= 77))
                {
                    Console.WriteLine("Your grade will be a C in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 70) && (Average <= 71))
                {
                    Console.WriteLine("Your grade will be a C- in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 68) && (Average <= 69))
                {
                    Console.WriteLine("Your grade will be a D+ in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 62) && (Average <= 67))
                {
                    Console.WriteLine("Your grade will be a D in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 60) && (Average <= 61))
                {
                    Console.WriteLine("Your grade will be a D- in the class");
                    Console.ReadKey(true);
                }

                if ((Average >= 0) && (Average <= 60))
                {
                    Console.WriteLine("Your grade will be an F in the class");
                    Console.ReadKey(true);
                }
            }//end of Try
            catch
            {
                Console.WriteLine("Please use a number between 0-100");
                Console.WriteLine("Press any key to exit the program and try again");

                Console.ReadKey(true);
            }//End of catch




        }
    }
}
