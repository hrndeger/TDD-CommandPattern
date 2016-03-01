using System;
using CommandPattern.Command;

namespace CommandPattern
{
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number :");

            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            var secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Operator. ( +,-,*,/)");
            string ope = (Console.ReadLine());

            Invoker invoker = GetOperator(ope, firstNumber, secondNumber);

            double result = invoker.Run();

            invoker.Print(result);
            Console.ReadLine();

        }

        /// <summary>
        /// Gets the operator.
        /// </summary>
        /// <param name="ope">The ope.</param>
        /// <param name="invoker">The invoker.</param>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        private static Invoker GetOperator(string ope, double firstNumber, double secondNumber)
        {
            Invoker invoker = new Invoker();

            switch (ope)
            {
                case "+":
                    invoker.Add(new AddCommand(firstNumber, secondNumber));
                    break;
                case "-":
                    invoker.Add(new SubstractCommand(firstNumber, secondNumber));
                    break;
                case "*":
                    invoker.Add(new MultiCommand(firstNumber, secondNumber));
                    break;
                case "/":
                    invoker.Add(new DivideCommand(firstNumber, secondNumber));
                    break;
                default:
                    Console.Write("Please enter valid operator");
                    break;
            }

            return invoker;
        }
    }
}
