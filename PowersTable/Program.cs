using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                string table = "";
                table += "Number\tSquared\tCubed\n";
                table += "======\t=======\t=====\n";

                for (int i = 1; i <= num; i++)
                {
                    int square = i * i;
                    int cube = i * i * i;
                    table += i + "\t" + square + "\t" + cube + "\n";
                }

                Console.WriteLine(table);
                Console.WriteLine();

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }

        }
    }
}
