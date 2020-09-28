using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int n = intervals.Length;

            if (n == 0)
                return new[] { newInterval }; // If is emtpy return only the new interval

            if (newInterval[1]<intervals[0][0]) //Si el tail del newInterval es mas chico que el head del primer Interval
            {                                   //Significa que va a ser el intervalo mas chico
                var arr = new int[n + 1][];
                arr[0] = newInterval;
                Array.Copy(intervals, 0, arr, 1, n);
                return arr;
            }

            if(newInterval[0]>intervals[n-1][1]) //Si el head del newInterval es mas grande que el Tail del ultimo interval
            {                                  //Signigica que va a ser el intervalo mas grande
                var arr = new int[n + 1][];
                arr[n] = newInterval;
                Array.Copy(intervals, 0, arr, 0, n);
                return arr;
            }

            List<int[]> res = new List<int[]>();

            bool found = false;
            int head = newInterval[0];
            int tail = newInterval[1];

            for (int i = 0; i < n; i++)
            {
                if(found || head > intervals[i][1]) // Si ya se agrego/merge el nuevo intervalo O el head del newInterval es mas
                {                                   // grande que el Tail del intervals, agrego este ultimo y sigo.
                    res.Add(intervals[i]);
                    continue;
                }
                if(tail < intervals[i][0])          //Si el head del newInterval es mas chico que el tail del interval 
                {                                   //y el tail es mas chico que el interval, entonces hay que agregarlo a la 
                    res.Add(new[] { head, tail });  //lista, se agrega el intervals y seteo el found en true para agregar
                    res.Add(intervals[i]);          //el resto
                    found = true;
                    continue;
                }

                head = Math.Min(intervals[i][0],head);
                if (tail < intervals[i][1])
                {
                    res.Add(new[] { head, intervals[i][1] });
                    found = true;
                    continue;
                }
            }
            if (!found)
            {
                res.Add(new[] { head,tail });
            }

            return res.ToArray();
        }
        
    }
}
