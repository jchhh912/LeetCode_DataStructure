using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 数组 静态和动态 泛型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Array1<T>
    {
        private T[] data;
        private int N;
        public Array1(int capacity)
        {
            data = new T[capacity];
            N = 0;
        }
        public Array1() : this(10) { }
        public int Capacity
        {
            get { return data.Length; }
        }
        public int Count
        {
            get { return N; }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        public void Add(int index, T value)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("越界");
            }
            if (N == data.Length)
            {
                ResetCapacity(2*N);
            }
            for (int i = N - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = value;
            N++;
        }
        /// <summary>
        /// 数组末尾添加
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            Add(N, value);
        }
        /// <summary>
        /// 数组首位添加
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            Add(0, value);
        }
        /// <summary>
        /// 获取某位的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("越界");
            }
            return data[index];
        }
        /// <summary>
        /// 获取第一位的值
        /// </summary>
        /// <returns></returns>
        public T GetFirst()
        {
            return data[0];
        }
        /// <summary>
        /// 获取最后一位的值
        /// </summary>
        /// <returns></returns>
        public T GetLast()
        {
            return data[N - 1];
        }
        /// <summary>
        /// 给指定位置赋值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Set(int index, T value)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("越界");
            }
            data[index] = value;
        }
        /// <summary>
        /// 查看是否存在值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 获取某个值的下标
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int IndexOf(int value)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 删除指定位置的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T RemoveAt(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("越界");
            }
            T del = data[index];
            for (int i = index + 1; i <= N - 1; i++)
            {
                data[i - 1] = data[i];
            }
            N--;
            data[N] = default(T);
            //缩容
            if (N==data.Length/4)
            {
                ResetCapacity(data.Length / 2);
            }
            return del;
        }
        /// <summary>
        /// 删除第一位的值
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }
        /// <summary>
        /// 删除最后一位的值
        /// </summary>
        /// <returns></returns>
        public T RemoveLast()
        {
            return RemoveAt(N-1);
        }
        /// <summary>
        /// 删除指定的值
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
        {
            int index = IndexOf(value);
            if (index!=-1)
            {
                RemoveAt(index);
            }
        }
        private void ResetCapacity(int newCapacity) 
        {
            T[] newdata = new T[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newdata[i] = data[i];
            }
            data = newdata;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1:  count={0}  capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1) 
                {
                    res.Append(",");
                }
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
