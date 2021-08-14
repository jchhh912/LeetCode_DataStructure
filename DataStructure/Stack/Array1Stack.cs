using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 数组栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Array1Stack<T>:IStack<T>
    {
        //由动态数组实现 =》数组栈
        private Array1<T> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array1Stack(int capacity) 
        {
            arr = new Array1<T>(capacity);
        }
        public Array1Stack() 
        {
            arr =new Array1<T>();
        }

        public void Push(T t)
        {
            arr.AddLast(t);
        }

        public T Pop()
        {
            return arr.RemoveLast();
        }

        public T Peek()
        {
            return arr.GetLast();
        }
        public override string ToString()
        {
            return "Stack:" + arr.ToString() + "Top";
        }
    }
}
