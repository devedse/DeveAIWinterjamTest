using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new AmazingNonAiCalculator();
            Console.WriteLine("1 + 2 = " + calculator.Add(1, 2));
            Console.WriteLine("1 - 2 = " + calculator.Substract(1, 2));
            Console.WriteLine("1 * 2 = " + calculator.Multiply(1, 2));
            Console.WriteLine("1 / 2 = " + calculator.Divide(1, 2));
            Console.WriteLine("1 % 2 = " + calculator.Modulo(1, 2));
        }
    }
}
