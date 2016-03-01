using System;
using System.Collections.Generic;
using System.Linq;
using CommandPattern.Interface;

namespace CommandPattern
{
    public sealed class Invoker
    {
        private readonly Stack<ICommand> m_Commands = new Stack<ICommand>();

        /// <summary>
        /// Runs this instance.
        /// </summary>
        /// <returns></returns>
        public double Run()
        {
            double result = default(int);

            while (m_Commands != null && m_Commands.Any())
            {
                result = m_Commands.Pop().Run();
            }

            return result;
        }

        /// <summary>
        /// Adds the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        public void Add(ICommand command)
        {
            if (m_Commands != null)
            {
                m_Commands.Push(command);
            }
        }

        /// <summary>
        /// Prints the specified result.
        /// </summary>
        /// <param name="result">The result.</param>
        public void Print(double result)
        {
            Console.WriteLine(result);
        }
    }
}