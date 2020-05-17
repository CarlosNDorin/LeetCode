using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CountPrimes
    {
        public int Countprimes(int n)
        {
            
             if (n < 2)
             {
                 return 0;
             }
             bool[] primes = new bool[n];
             int count = 0;
             for(int outterLoop = 2; outterLoop <= (int)Math.Sqrt(n); outterLoop++)
             {
                 for(int inner = outterLoop * outterLoop; inner <= n; inner += outterLoop )
                 {
                     if (!primes[inner])
                         primes[inner] = true;
                 }
             }

             for(int i = 2; i<n; i++)
             {
                 if (!primes[i])
                     count++;
             }
             return count;
         
        }
    }
    /* //if 0 nor 1 are primes
        public int Countprimes(int n)
        {
            if (n <= 2)
                return 0;
            int result = 2;
            for(int i = 4; i<n; i++)
            {
                if (isPrime(i))
                    result++;
            }
            return result;
        }
        public bool isPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                    return false;
            }
            return true;
        }FUNCIONA PERO ES LEEENTOOO*/ 
}
