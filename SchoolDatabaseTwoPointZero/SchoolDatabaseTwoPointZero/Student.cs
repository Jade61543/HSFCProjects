using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseTwoPointZero
{
    public class Student: Person //Inherits Person
    {
        //every student will have a student number

        private string studentNum; //Has to be string because an int would
                                        //lose all zeros before the first significant num (0005 = 5)

        public Student(string theName, int theAge, Address anAddress, string theSNum):base(theName, theAge, anAddress)
        {

        }
    }
}
