using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 链表栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList1Stack<T> : IStack<T>
    {
        private LinkedList1<T> list;
        public LinkedList1Stack()
        {
            list = new LinkedList1<T>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty;  } }

        public T Peek()
        {
           return list.GetFirst();
        }

        public T Pop()
        {
            return list.RemoveFirst();    
        }

        public void Push(T t)
        {
            list.AddFirst(t);
        }
        public override string ToString()
        {
          return "Stack:" + list.ToString() + "Top"; ;
        }
    }
}
