using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 数组队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Array1Queue<T>:IQueue<T>
    {
        private Array1<T> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array1Queue(int capacity) 
        {
            arr = new Array1<T>(capacity);
        }
        public Array1Queue() 
        {
            arr = new Array1<T>();
        }

        public void Enqueue(T t)
        {
            arr.AddLast(t);
        }
        /// <summary>
        /// 出队 O(n)
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
           return arr.RemoveFirst();
        }

        public T Peek()
        {
            return arr.GetFirst();
        }
        public override string ToString()
        {
            return "Queue: front"+arr.ToString()+"tail";
        }
    }
}
