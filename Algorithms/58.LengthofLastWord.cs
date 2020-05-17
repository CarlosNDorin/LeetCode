using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            List<string> ListOfWords = s.Split(' ').ToList();
            ListOfWords.RemoveAll(item => item=="");
            if (ListOfWords.Count() == 0)
                return -1;
            else
                return ListOfWords.LastOrDefault().Length;
          
        }
    }
}
