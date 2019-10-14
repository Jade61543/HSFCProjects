using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[10];
            int intTotal = 10;
            int intCount = 0;

            Console.WriteLine("Please enter 10 integers to be sorted: use 1 line per integer & hit enter between each.");
            for (int num = 0; num < intTotal; num++)
            {
                intCount += 1;
                Console.WriteLine("/nEnter integer number " + intCount);
                array[num] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("\nYour unsorted integers are:");
            for (int num = 0; num < intTotal; num++)
            {
                Console.Write(array[num]);
                Console.Write(", ");
            }

            Console.ReadLine();
        }
    }
}
