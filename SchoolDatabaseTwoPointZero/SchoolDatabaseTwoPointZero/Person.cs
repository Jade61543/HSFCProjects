using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseTwoPointZero
{
    public class Person
    {
        private string name;
        private int age;
        private Address livesAt;


        public Person(string aName, int anAge, Address aLocation)
        {
            name = aName;
            age = anAge;
            livesAt = aLocation;
        }

        public Person()
        { }


        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public Address GetAddress()
        {
            return livesAt;
        }

        public void SetName(string inputName)
        {
            name = inputName;
        }

        public void SetAge (int inputAge)
        {
            age = inputAge;
        }

        public void SetAddress (Address theAddress)
        {
            livesAt = theAddress;
        }
 

        public override string ToString()
        {
            return this.GetName() + " is aged " + this.GetAge() + Environment.NewLine + this.GetAddress();
        }

    }
}
