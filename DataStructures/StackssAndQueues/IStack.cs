using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackssAndQueues
{
    interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        bool IsEmpty { get; }

    }
}
