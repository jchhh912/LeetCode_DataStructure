using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 双向链表的队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList2Queue<T>:IQueue<T>
    {
        private LinkedList2<T> list;
        public LinkedList2Queue()
        {
            list = new LinkedList2<T>();
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
            return "Queue Front:" + list.ToString() + "tail";
        }
    }
}
