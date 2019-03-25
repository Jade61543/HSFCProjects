using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseTwoPointZero
{
    public class Address
    {
        private string houseNameOrNum;
        private string street;
        private string county;
        private string postcode;


        public Address(string aHouseNameOrNum, string aStreet, string aCounty, string aPostcode)
        {
            houseNameOrNum = aHouseNameOrNum;
            street = aStreet;
            county = aCounty;
            postcode = aPostcode;
        }

        public Address()
        { }


        public string GetHouseNameOrNum()
        {
            return houseNameOrNum;
        }

        public string GetStreet()
        {
            return street;
        }


        public string GetCounty()
        {
            return county;
        }

        public string GetPostcode()
        {
            return postcode;
        }


        public void SetHouseNameOrNum (string inputHouse)
        {
            houseNameOrNum = inputHouse;
        }

        public void SetStreet (string inputStreet)
        {
            street = inputStreet;
        }

        public void SetCounty (string inputCounty)
        {
            county = inputCounty;
        }

        public void SetPostCode (string inputPostCode)
        {
            postcode = inputPostCode;
        }


        public override string ToString()
        {
            return houseNameOrNum + ", " + street + ", " + county + ", " + postcode + ".";
        }
    }
}
