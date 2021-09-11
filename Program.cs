/*
Project/Programmer:ISM 4300 Tech Project 2 -- Submitted By Marisa Momper
Date: 9/11/2021
Description: Use conditional statements to ask a user what grade they would expect to get and inform them of the corresponding letter grade they should expect based on their input
*/
using System;

namespace Tech_Project_2___Marisa_Momper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input the grade they expect to recieve
            Console.WriteLine("What grade do you expect to get in ISM 4300? (Please enter an integer value between 0 and 100");

            //Use a try catch block to check that the input the user entered is a valid input.
            //Catch block will cause an error message to display if the input is not valid
            try
            {
                //Declares an integer variable for grade and assigns the input from the user to the variable
                int grade = int.Parse(Console.ReadLine());

                //Begins to process the integer value
                //Checks to see if the grade is an A
                if(grade >= 93 && grade <=100)
                {
                    Console.WriteLine("You would get an A");
                }

                //Checks to see if the grade is an A-
                else if(grade >=90 && grade <=92)
                {
                    Console.WriteLine("You would get a A-");
                }

                //Checks to see if the grade is a B+
                else if (grade >= 87 && grade <= 89)
                {
                    Console.WriteLine("You would get a B+");
                }

                //Checks to see if the grade is a B
                else if (grade >= 83 && grade <= 86)
                {
                    Console.WriteLine("You would get a B");
                }

                //Checks to see if the grade is a B-
                else if (grade >= 80 && grade <= 82)
                {
                    Console.WriteLine("You would get a B-");
                }
                //Checks to see if the grade is a C+
                else if (grade >= 77 && grade <= 79)
                {
                    Console.WriteLine("You would get a C+");
                }

                //Checks to see if the grade is a C
                else if (grade >= 73 && grade <= 76)
                {
                    Console.WriteLine("You would get a C");
                }

                //Checks to see if the grade is a C-
                else if (grade >= 70 && grade <= 72)
                {
                    Console.WriteLine("You would get a C-");
                }

                //Checks to see if the grade is a D+
                else if (grade >= 67 && grade <= 69)
                {
                    Console.WriteLine("You would get a D+");
                }

                //Checks to see if the grade is a D
                else if (grade >= 63 && grade <= 66)
                {
                    Console.WriteLine("You would get a D");
                }

                //Checks to see if the grade is a D-
                else if (grade >= 60 && grade <= 62)
                {
                    Console.WriteLine("You would get a D-");
                }

                //Checks to see if the grade is a F
                else if (grade >= 0 && grade <= 59)
                {
                    Console.WriteLine("You would get a F");
                }
                //if the grade does not meet one of the previous conditions than it is outside the bounds of the accepted values for grade and another input is requested
                else
                {
                    Console.WriteLine("Please run again and enter a grade that is an integer value between 0 and 100");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            } //end of try block

            //Catch statement that catches input errors which are not integer values
            catch
            {
                Console.WriteLine("Please run again and enter a grade that is an integer value between 0 and 100");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } //end of catch block
        }
    } //end of class
} //end of namespace
