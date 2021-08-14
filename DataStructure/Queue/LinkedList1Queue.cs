using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 单向链表的队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList1Queue<T>:IQueue<T>
    {
        private LinkedList1<T> list;
        public LinkedList1Queue() 
        {
            list = new LinkedList1<T>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public T Dequeue()
        {
           return list.RemoveFirst();
        }

        public void Enqueue(T t)
        {
            list.AddLast(t);
        }

        public T Peek()
        {
            return list.GetFirst();
        }
        public override string ToString()
        {
            return "Queue Front:"+list.ToString()+"tail";
        }
    }
}
