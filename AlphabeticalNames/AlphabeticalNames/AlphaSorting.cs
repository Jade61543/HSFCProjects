using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabeticalNames
{
    class AlphaSorting
    {
        private string[] theNames = new string[10];
        private int nextFree = 0;
        private bool isSorted = false;
        string temp;

        public void AddName(string aName)
        {
            if (nextFree < theNames.Length)
            {
                theNames[nextFree] = aName;
                nextFree++;
            }

            SortNames();
        }

        private void SortNames()
        {
            while (isSorted == false)
            {
                isSorted = true;
                for (int num = 0; num < nextFree; num++)
                {
                    if (theNames[num].CompareTo(theNames[num+1]) > 0) //need to add a case for position 0 as there is nothing to compare it to.
                    {
                        temp = theNames[num];
                        theNames[num] = theNames[num +1];
                        theNames[num +1] = temp;

                        isSorted = false;
                    }
                }
            }
        }

        public string GetNames()
        {
            string sortedNames = "";

            for (int num = 0; num < theNames.Length; num++)
            {
                sortedNames += theNames[num] + "    ";
            }

            return sortedNames;
        }

    }
}
