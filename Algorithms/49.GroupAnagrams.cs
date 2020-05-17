using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GroupAnagrams
    {
       public IList<IList<string>> groupAnagrams(string [] strs)
       {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            IList<IList<string>> result = new List<IList<string>>();
           
            foreach(string s in strs)
            {
                char[] localArray = s.ToArray();
                Array.Sort(localArray);
                string localString = new string(localArray);
                if(!dic.ContainsKey(localString))
                {
                    dic.Add(localString, new List<string> { s });
                }
                else
                {
                    dic[localString].Add(s);
                }
            }
        
            foreach(KeyValuePair<string,IList<string>> value in dic)
            {
                result.Add(value.Value);
            }

            return result;
       }
    }
}
