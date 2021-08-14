using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 循环数组队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Array2Queue<T>:IQueue<T>
    {
        //以循环数组为底层的数据结构
        private Array2<T> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array2Queue(int capacity)
        {
            arr = new Array2<T>(capacity);
        }
        public Array2Queue()
        {
            arr = new Array2<T>();
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
            return "Queue: front" + arr.ToString() + "tail";
        }
    }
}
