using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MyQueue
    {

        public Stack<int> actual = new Stack<int>();
        public Stack<int> invert = new Stack<int>();

        /** Initialize your data structure here. */
        public MyQueue()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while(actual.Count != 0)
            {
               invert.Push(actual.Pop());
            }
            actual.Push(x);
            while(invert.Count !=0)
            {
                actual.Push(invert.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return actual.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return actual.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return actual.Count() == 0;
        }
    }
}
