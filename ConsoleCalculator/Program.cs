﻿using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += CurrentAppDomain_UnhandledException;

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
            catch (CalculationException ex)
            {
                // log error
                WriteLine(ex);
            }
            // only executes the catch block when ParamName == "operation", to test it put 
            // throw new ArgumentNullException(nameof(operation)); on Calculate.Calculator method
            //catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            //{
            //    WriteLine($"\n Operation was not provided: {ex}");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    WriteLine($"\n An argument was null: {ex}");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    WriteLine($"\n Operation is not supported: {ex}");
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"\n Something went wrong: {ex}");
            //}
            finally
            {
                WriteLine("... finally ...");
            }

            WriteLine("\n Press enter to exit");
            ReadLine();
        }

        private static void CurrentAppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteLine($"Sorry there was a problem and we need to close.  Details: {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
