using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var a = 17;
            var b = 4;
            var div = (a / b);
            var mod = (a % b);

            Console.WriteLine($"{a} divided by {b} is {div} with a remainder of {mod}");*/
            Console.WriteLine("Please enter a number.");
            var r = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            double result = (pi * r * r);

            Console.WriteLine($"The Area of a Circle with a radius of {r} equals {result}. the formula is {pi} * {r} * {r}");
        }  

    }

}
