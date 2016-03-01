using CommandPattern.Interface;

namespace CommandPattern.Command
{
    public sealed class AddCommand : ICommand
    {
        private readonly double m_FirstNumber;
        private readonly double m_SecondNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCommand"/> class.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        public AddCommand(double firstNumber, double secondNumber)
        {
            m_FirstNumber = firstNumber;
            m_SecondNumber = secondNumber;
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        /// <returns></returns>
        public double Run()
        {
            double result = m_FirstNumber + m_SecondNumber;
            return result;
        }
    }
}