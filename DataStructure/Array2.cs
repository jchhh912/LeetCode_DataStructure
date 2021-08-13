using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 循环数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Array2<T>
    {
        private T[] data;
        private int first;
        private int last;
        private int N;
        public Array2(int capacity) 
        {
            data = new T[capacity];
            first = 0;
            last = 0;
            N = 0;
        }
        public Array2() : this(10) { }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N ==0; } }
        public void AddLast(T t)
        {
            if (N==data.Length)
            {
                ResetCapacity(2*data.Length );
            }
            data[last] = t;
            last = (last + 1) % data.Length;
            N++;
        }
        public T RemoveFirst() 
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("数组为空");
            }
            T value = data[first];
            data[first] = default(T);
            first = (first + 1) % data.Length;
            N--;
            if (N==data.Length/4)
            {
                ResetCapacity(data.Length/2);
            }
            return value;
        }
        public T GetFirst() 
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("数组为空");
            }
            return data[first];
        }
        private void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[(first + i) % data.Length];
            }
            data = newData;
            first = 0;
            last = N;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("[");
            for (int i = 0; i < N; i++)
            {
                str.Append(data[(first+i)%data.Length]);
                if ((first+i+1)%data.Length!=last)
                {
                    str.Append(",");
                }
            }
            str.Append("]");
            return str.ToString();
        }
    }
}
