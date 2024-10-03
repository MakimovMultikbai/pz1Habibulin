using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz1Habibulin
{
    public class mathematic
    {
        public string Plus(double a, double b)
        {
            return $"{a} + {b} = {a+b}";
        }

        public string Minus(double a, double b)
        {
            return $"{a} - {b} = {a - b}";
        }

        public string Divide(double a, double b)
        {
            return $"{a} / {b} = {a / b}";
        }

        public string Multiply(double a, double b)
        {
            return $"{a} * {b} = {a * b}";
        }

        public string Pow(double a, int b)
        {
            double x = a;
            for (int i = 0; i < b; i++) 
            {
                x *= a;      
            }
            return $"{a}^{b} = {x}";
        }

        public string bolshee(double a, double b)
        {
            if (a < b) 
            {
                return $"Большее число {b}";
            }
            else if (a > b)
            {
                return $"Большее число {a}";
            }
            else
            {
                return $"Числа равны";
            }
        }
    }
}
