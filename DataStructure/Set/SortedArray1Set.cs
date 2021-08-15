using DataStructure.Array;
using System;

namespace DataStructure.Set
{
    /// <summary>
    /// 顺序数组实现集合
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    class SortedArray1Set<Key>:ISet<Key> where Key:IComparable<Key>
    {
        private SortedArray1<Key> s;

        public int Count { get { return s.Count; } }

        public bool IsEmpty { get { return s.IsEmpty; } }

        public SortedArray1Set(int capacity)
        {
            s = new SortedArray1<Key>(capacity);
        }
        public SortedArray1Set() 
        {
            s = new SortedArray1<Key>();
        }

        public void Add(Key t)
        {
            s.Add(t);
        }

        public void Remove(Key t)
        {
            s.Remove(t);
        }

        public bool Contains(Key t)
        {
           return s.Contains(t);
        }
    }
}
