using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCal
{
    interface InterStack<T>
    {
        void Push(T elem);
        T Pop();
    }
}
