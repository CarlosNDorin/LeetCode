using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ImplementStackusingQueues
    {
        public class MyStack
        {
            Queue<int> qStack = new Queue<int>();
            private  int count = 0;
            /** Initialize your data structure here. */
            public MyStack()
            {

            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                qStack.Enqueue(x);
                count = qStack.Count();
                for(int i = 1; i< count; i++)
                {
                    qStack.Enqueue(qStack.Dequeue());
                }
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                if (qStack.Count == 0)
                    return 0;
                return qStack.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return qStack.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                if (qStack.Count == 0)
                    return true;
                else
                    return false;
            }
        }
        /* Your MyStack object will be instantiated and called as such:
         * MyStack obj = new MyStack();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Top();
         * bool param_4 = obj.Empty();
         */
    }
}
