using DataStructure.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Dictionary
{
    /// <summary>
    /// 排序数组字典
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class SortedArray2Dictionary<Key, Value> : IDictionary<Key, Value> where Key : IComparable<Key>
    {
        private SortedArray2<Key, Value> s2;

        public int Count { get { return s2.Count; } }

        public bool IsEmpty { get { return s2.IsEmpty; } }

        public SortedArray2Dictionary(int capacity)
        {
            s2 = new SortedArray2<Key, Value>(capacity);
        }
        public SortedArray2Dictionary()
        {
            s2 = new SortedArray2<Key, Value>();
        }

        public void Add(Key key, Value value)
        {
            s2.Add(key,value);
        }

        public void Remove(Key key)
        {
            s2.Remove(key);
        }

        public bool ContainsKey(Key key)
        {
          return  s2.Contains(key);
        }

        public Value Get(Key key)
        {
            return s2.Get(key);
        }

        public void Set(Key key, Value newvalue)
        {
            s2.Add(key,newvalue);
        }
    }
}
