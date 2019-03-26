using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseTwoPointZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempHouseNameNum;
            string tempStreet;
            string tempCounty;
            string tempPostcode;


            Person p1 = new Person();


            Console.WriteLine("Please input your name. \n");
            p1.SetName(Console.ReadLine());

            Console.WriteLine("\nPlease input your age. \n");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nPlease enter your house name or number \n");
            tempHouseNameNum = Console.ReadLine();

            Console.WriteLine("\nPlease enter your street name \n");
            tempStreet = Console.ReadLine();

            Console.WriteLine("\nPlease enter your county \n");
            tempCounty = Console.ReadLine();

            Console.WriteLine("\nPlease enter your postcode \n");
            tempPostcode = Console.ReadLine();

            Address a1 = new Address(tempHouseNameNum, tempStreet, tempCounty, tempPostcode);
            p1.SetAddress(a1);

            Console.WriteLine("\n\n" + p1.ToString());
            Console.WriteLine(a1.ToString());


            Console.WriteLine("\n\nPlease enter your name, age, house name or number, street, county and postcode. All MUST be on separate lines");
            Address a2;
            Person p2 = new Person(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), a2 = new Address(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine("\n" + p2);

            Console.ReadLine();
        }
    }
}
