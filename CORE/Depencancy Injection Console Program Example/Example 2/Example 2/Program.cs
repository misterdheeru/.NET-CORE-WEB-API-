using System;

namespace Example_2
{
    interface ICalculate
    {
        int Add(int a, int b);
        int Sub(int a, int b);
    }

    class Calculate : ICalculate
    {
        public int Add(int a, int b)
        {
            int res = a + b;
            return res;
        }

        public int Sub(int a, int b)
        {
            int res = a - b;
            return res;
        }
    }

    class CalculateRepo
    {
        private readonly ICalculate cal;

        public CalculateRepo(ICalculate cal)
        {
            this.cal = cal;
        }

        public void Display(int a, int b)
        {
            Console.WriteLine($"Addition: {cal.Add(a, b)}");
            Console.WriteLine($"Subtraction: {cal.Sub(a, b)}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of Dependency Injection
            ICalculate calculator = new Calculate();
            CalculateRepo calculatorRepo = new CalculateRepo(calculator);

            // Provide values for a and b
            int a = 10;
            int b = 5;

            // Display results
            calculatorRepo.Display(a, b);
        }
    }
}
