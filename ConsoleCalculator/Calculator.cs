using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            // throw new ArgumentNullException(nameof(number1));
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    // log error 
                    // throws the error preserving stack trace
                    //throw;

                    // wraps the exception inside another exception, to give a more general message, for example
                    throw new ArithmeticException("An error ocurred during calculation", ex);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported");
                //Console.WriteLine("Uknown operation");
                //return 0;
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
