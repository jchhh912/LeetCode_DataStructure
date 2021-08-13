﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Push(T t);
        T Pop();
        T Peek();
    }
}
