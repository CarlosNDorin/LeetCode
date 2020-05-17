using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int profit = 0;
            for(int i = 0; i< prices.Length-1; i++)
            {
                if (prices[i] < prices[i + 1])
                    profit += prices[i + 1] - prices[i];
            }
            return profit;
        }
    }
}
