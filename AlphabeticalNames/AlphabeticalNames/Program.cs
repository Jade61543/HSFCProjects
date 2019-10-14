using System;

namespace AlphabeticalNames
{
    class Program
    {
        static void Main(string[] args)
        {
            AlphaSorting sortedNameList = new AlphaSorting();

            for (int num = 0; num < 10; num++)
            {
                Console.WriteLine("Please enter a name");
                sortedNameList.AddName(Console.ReadLine());
            }

            Console.WriteLine("\nIn alphabetical order is: " + sortedNameList.GetNames());
            Console.ReadLine();
        }
    }
}
