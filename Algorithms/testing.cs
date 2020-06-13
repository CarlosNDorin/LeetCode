using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class testing
    {

        public void test()
        {
            List<stam> list = new List<stam>();
            Dictionary<int, List<stam>> keyValuePairs = new Dictionary<int, List<stam>>();
            stam stam1 = new stam();
            list.Add(stam1);
            keyValuePairs.Add(1, list);
            Console.WriteLine(list[0].ToString());
            stam1.variable1 = 4;
            Console.WriteLine(list[0].ToString());


        }
    }


    class stam
    {
        public int variable1 = 1;
        public int variable2 = 2;

        public override string ToString()
        {
            return " var 1: "+ variable1 + " var 2: " + variable2; 
        }
    }
}
