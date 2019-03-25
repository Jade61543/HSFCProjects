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

            Console.WriteLine("Please input your age. \n");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Please enter your house name or number \n");
            tempHouseNameNum = Console.ReadLine();

            Console.WriteLine("Please enter your street name \n");
            tempStreet = Console.ReadLine();

            Console.WriteLine("Please enter your county \n");
            tempCounty = Console.ReadLine();

            Console.WriteLine("Please enter your postcode \n");
            tempPostcode = Console.ReadLine();

            Address a1 = new Address(tempHouseNameNum, tempStreet, tempCounty, tempPostcode);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(a1.ToString());

            Console.ReadLine();
        }
    }
}
