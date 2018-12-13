using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();

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

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
