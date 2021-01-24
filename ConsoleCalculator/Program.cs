using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number:");
            int number1 = int.Parse(ReadLine());
            WriteLine("Enter second number:");
            int number2 = int.Parse(ReadLine());
            WriteLine("Enter operation:");
            string operation = ReadLine().ToUpperInvariant();

            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"\n Operation was not provided: {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine($"\n Operation is not supported: {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"\n Something went wrong: {ex}");
            }
            finally
            {
                WriteLine("... finally ...");
            }

            WriteLine("\n Press enter to exit");
            ReadLine();
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
