using System;
using System.Collections.Generic;

namespace SimpleApplication
{
    public class Program
    {
        public static void Main()
        {
            Program calculator = new Program();
            List<float> numbers = calculator.UserInput();

            float sum = calculator.SumOfNumbers(numbers[0], numbers[1]);

            Console.WriteLine($"Sum of {numbers[0]} and {numbers[1]} is: {sum}");
        }

        public float SumOfNumbers(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public List<float> UserInput()
        {
            List<float> result = new List<float>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter the {i + 1} number: ");
                float number = float.Parse(Console.ReadLine()!);
                result.Add(number);
            }

            return result;
        }
    }
}
