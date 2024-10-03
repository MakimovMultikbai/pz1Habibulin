using pz1Habibulin;
using System;
using static pz1Habibulin.mathematic;

namespace pz1Habibulin
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            mathematic math = new mathematic();

            double a = 10.2;
            double b = 8.7;
         
            Console.WriteLine(math.Plus(a, b));
            Console.WriteLine();

            Console.WriteLine(math.Minus(a, b));
            Console.WriteLine();

            Console.WriteLine(math.Multiply(a, b));
            Console.WriteLine();

            Console.WriteLine(math.Divide(a, b));
            Console.WriteLine();

            Console.WriteLine(math.Pow(a, (int)b));
            Console.WriteLine();

            Console.WriteLine(math.bolshee(a,b));
            Console.WriteLine(); 
            
            Console.ReadKey();
        }
    }
}
