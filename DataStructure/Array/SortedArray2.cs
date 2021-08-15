using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    /// <summary>
    ///  有序数组实现字典保存键值对  映射
    ///  存储的元素必须是可以比较的，这样才可以排序
    ///  数据类型Key必需是实现了可比较接口Icomparable 才可以进行元素存储
    ///  Where key：IComparable 对Key进行泛型约束限定K不能是任意类型
    /// </summary>
    /// <typeparam name="Key">where key  限定为一个可以比较的类</typeparam>
    class SortedArray2<Key,Value> where Key : IComparable<Key>
    {
        private Key[] keys;
        private Value[] values;
        private int N;
        public SortedArray2(int capacity)
        {
            keys = new Key[capacity];
            values = new Value[capacity];
        }
        public SortedArray2() : this(10) { }
        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Rank(Key key)
        {
            int l = 0;
            int r = N - 1;
            while (l <= r)
            {
                //int min = (l + r) / 2;  当L 和R 值都很打时  Int 可能会整形溢出
                int min = l + (r - l) / 2;
                if (key.CompareTo(keys[min]) < 0)
                {
                    r = min - 1;
                }
                else if (key.CompareTo(keys[min]) > 0)
                {
                    l = min + 1;
                }
                else
                {
                    return min;
                }
            }
            return l;
        }
        public Value Get(Key key) 
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }
            int i = Rank(key);
            if (i<N&&keys[i].CompareTo(key)==0)
            {
                return values[i];
            }
            else
            {
                throw new ArgumentException("不存在");
             }
        }
        public void Add(Key key,Value value)
        {
            int i = Rank(key);
            if (N == keys.Length)
            {
                ResetCapacity(2 * keys.Length);
            }
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                values[i] = value;
                return;
            }
            for (int j = N - 1; j >= i; j--)
            {
                keys[j + 1] = keys[j];
                values[j + 1] = values[j];
            }
            keys[i] = key;
            values[i] = value;
            N++;
        }
        public void Remove(Key key)
        {
            if (IsEmpty) return;
            int i = Rank(key);
            if (i == N || keys[i].CompareTo(key) != 0)
            {
                return;
            }
            for (int j = i + 1; j <= N - 1; j++)
            {
                keys[j - 1] = keys[j];
                values[j - 1] = values[j];
            }
            N--;
            keys[N] = default(Key);
            values[N] = default(Value);
            if (N == keys.Length / 4)
            {
                ResetCapacity(keys.Length / 2);
            }
        }
        public Key Min()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }
            return keys[0];
        }
        public Key Max()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }
            return keys[N - 1];
        }
        public Key Select(int k)
        {
            if (k < 0 || k >= N)
            {
                throw new ArgumentException("索引越界");
            }
            return keys[k];
        }
        public bool Contains(Key key)
        {
            int i = Rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 找出小于或等于key的最大键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Key Floor(Key key)
        {
            int i = Rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return keys[i];
            }
            if (i == 0)
            {
                throw new ArgumentException("没找到小于或等于Key的最大键");
            }
            return keys[i - 1];
        }
        /// <summary>
        /// 找出大于或等于Key的最小键
        /// </summary>
        /// <returns></returns>
        public Key Ceiling(Key key)
        {
            int i = Rank(key);
            if (i == N)
            {
                throw new ArgumentException("没找到大0于或等于Key的最小键");
            }
            else
            {
                return keys[i];
            }
        }
        private void ResetCapacity(int newCapacity)
        {
            Key[] newKeys = new Key[newCapacity];
            Value[] newValue = new Value[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newKeys[i] = keys[i];
                newValue[i] = values[i];
            }
            keys = newKeys;
            values = newValue;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1:  count={0}  capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append("{"+keys[i]+","+values[i]+"}");
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
