using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the letter grade converter!");
            int grade;
            string tryAgain = "n";
            do
            {
                Console.Write("Enter a numerical grade: ");
                grade = int.Parse(Console.ReadLine());
                if (grade > 97 && grade < 101)
                {
                    Console.WriteLine("Letter Grade A+");
                }
                else if (grade > 87 && grade < 99)
                {
                    Console.WriteLine("Letter grade A");
                }
                else if (grade > 85 && grade < 88)
                {
                    Console.WriteLine("Letter grade B+");
                }
                else if (grade > 79 && grade < 86)
                {
                    Console.WriteLine("Letter grade B");
                }
                else if (grade > 77 && grade < 80)
                {
                    Console.WriteLine("Letter grade C+");
                }
                else if (grade > 66 && grade < 78)
                {
                    Console.WriteLine("Letter grade C");
                }
                else if (grade > 64 && grade < 67)
                {
                    Console.WriteLine("Letter grade D+");
                }
                else if (grade > 59 && grade < 65)
                {
                    Console.WriteLine("Letter grade D");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Letter grade F");
                }
                Console.Write("Would you like to continue? (y/n) ");
                tryAgain = Console.ReadLine();
            }
            while (tryAgain == "y" || tryAgain == "Y");

            Console.WriteLine("Goodbye");
            Console.ReadLine();

        }
    }
}
