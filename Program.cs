using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== AGE CALCULATOR =====");
                Console.Write("Enter your birthdate (YYYY-MM-DD) or type 'exit' to quit: ");

                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting... Have a great day!");
                    break;
                }

                if (DateTime.TryParse(input, out DateTime birthdate))
                {
                    int age = CalculateAge(birthdate);
                    Console.WriteLine($"You are {age} years old.");
                }
                else
                {
                    Console.WriteLine("Invalid date format! Please enter a valid date (YYYY-MM-DD).");
                }

                Console.WriteLine("\nPress Enter to calculate again...");
                Console.ReadLine();
            }
        }

        static int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            // Adjust if the birthday has not occurred yet this year
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }








}
