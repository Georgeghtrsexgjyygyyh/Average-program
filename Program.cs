using System;

namespace Cool_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double number_1;
            double number_2;
            double number_3;

            Console.WriteLine("Input a first number: ");

            number_1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Input a second number: ");

            number_2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Input a third number: ");

            number_3 = Convert.ToDouble(Console.ReadLine());


            double result = (number_1 + number_2 + number_3) / 3;


            Console.WriteLine("Result: " + result);


            Console.ReadKey();

        }
    }
}
