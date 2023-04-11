using System;

namespace Arrays_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //To determine the size of an array, ask for a full number.
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            //gets the array's length.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            //find the arrays' totals
            Console.WriteLine($"The sum of the array is (sum)");

            //arrays of numbers are sorted from smallest to largest.
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
