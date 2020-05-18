using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {

            if (intervals == null || intervals.Count() == 0) //Check if it empty or only 1 element
                return intervals;

            List<Intervals> interval = new List<Intervals>();
            List<int[]> result = new List<int[]>();

            for(int i = 0; i < intervals.Count();i++)
            {
                interval.Add(new Intervals(intervals[i][0], intervals[i][1])); //add elements to the list
            }
            int length = interval.Count();
            interval = interval.OrderBy(x => x.start).ThenBy(x => x.end).ToList(); // Order by start time and then end time.

            int start = 0; //init
            int end = 0;
            int j = 0;

            while (j < length) // from 0 to the last value
            {
                start = interval[j].start;
                end = interval[j].end;
                j++;
                
                while(j < length && interval[j].start <= end) //Mientras este en el rango y el start del actual sea menor al end anterior
                {
                    end = Math.Max(end, interval[j].end); // Elegir el mayor end y siguir hasta terminar o un inicio de hora
                    j++;                                  // mas grande que el actual start.
                }
                result.Add(new int[] { start, end }); // agrego a la lista
            }
            return result.ToArray();
        }
    }

    public class Intervals
    {
        public int start;
        public int end;

        public Intervals(int Start, int End)
        {
            start = Start;
            end = End;
        }
    }
}

/*
 * List<int[]> result = new List<int[]>();
            int[] prev = null;
            var intervalsSorted = intervals.OrderBy(val => val[0]);
            
            foreach(var interval in intervalsSorted)
            {
                if(prev != null && interval[0] <= prev[1])
                {
                    if (prev[1] < interval[1])
                        prev[1] = interval[1]; 
                }
                else
                {
                    prev = interval;
                    result.Add(prev);
                }
            }
            return result.ToArray();
*/
