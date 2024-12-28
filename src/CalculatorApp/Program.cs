using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Addition Result: " + calculator.Add(5, 7));
        }
    }
}