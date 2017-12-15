using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculator
{
    class Stack<S>
    {
        public S[] stack;
        public int top;
        private S result;
        public Stack()
        {
            stack = new S[200];
            top = 0;
        }
        public void Push(S giatri)
        {
            stack[top] = giatri;
            top++;
        }
        public S Pop()
        {
           
            if (top > 0)
            {
                result = stack[top - 1];
                top--;
            }
            return result;
        }
        public S Peek()
        {
            if(top > 0)
            {
                return stack[top - 1];
            }
            return stack[top - 1];
        }
        public bool IsEmpty()
        {
            if (top == 0)
                return true;
            return false;
        }
        public int Count()
        {
            return top;
        }
        
    }
}
