using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Message that is written to the user when the program starts
            Console.WriteLine("Select a language by entering: 1, 2, 3");

            // Possible language options
            Console.WriteLine("Language number 1 is C#");
            Console.WriteLine("Language number 2 is C++");
            Console.WriteLine("Language number 3 is C");

            // Conditional message for the next step
            Console.WriteLine("Enter a number: ");

            // We ask the user to enter a number,
            // where we use the string for ReadLine();
            string language = Console.ReadLine();

            // Later, we turn that string into an int for further action
            int Language = Convert.ToInt32(language);


            // We use the resulting int in the following form
            switch (Language)
            {
                case 1: Console.WriteLine(" Your language is: C#");
                        break;
                case 2:
                    Console.WriteLine(" Your language is: C++");
                    break;
                case 3:
                    Console.WriteLine(" Your language is: C");
                    break;
                // Deafult , in case the user selects a number that is not offered
                default:
                    Console.WriteLine("Selected Language is an unknown");
                    break;
            }
            

        }
    } 
}


