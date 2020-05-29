using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            IList<string> result = new List<string>();
            if(num == 0 )
            {
                result.Add("0:00");
                return result;
            }

            for(int h = 0; h<12; h++)
            {
                for(int m = 0; m<60; m++)
                {
                    if((countBits(m)+countBits(h))==num)
                    {
                        string toAdd = h.ToString() + ":" + m.ToString().PadLeft(2, '0');
                        result.Add(toAdd);
                    }
                }
            }
            return result;
        }

        private int countBits(int val)
        {
            int count = 0;
            while(val != 0)
            {
                if((val & 1) == 1)
                {
                    count++;
                }
                val >>= 1;
            }
            return count;
        }
    }
}


/*
 * 
            IList<string> result = new List<string>();
            if (num == 0)
            {
                result.Add("0:00");
                return result;

            }
            List<string> ListOfHours = new List<string>();
            List<string> ListOfMinutes = new List<string>();
            
            int[] hour = { 1, 2, 4, 8 };
            int[] min = { 1, 2, 4, 8, 16, 32 };

            resultCombination(ListOfHours, hour, num, 0, new int());
            resultCombination(ListOfMinutes, min, num, 0, new int());
            foreach(string s in ListOfHours)
            {
                foreach(string a in ListOfMinutes)
                {
                    string toAdd = s + ":" + a.PadLeft(2,'0');
                    result.Add(toAdd);
                }
            }
            return result;
        }



        private void resultCombination (List<string> listOfCombinations, int[] combination, int num, int start, int selected)
        {
            if(num == 0)
            {
                string toAdd = selected.ToString();
                listOfCombinations.Add(toAdd);
                return;
            }

            for(int i = start; i< combination.Count(); i++)
            {
                selected += combination[i];
                resultCombination(listOfCombinations, combination, num-1, i+1, selected);
                selected -= combination[i];
            }
*/