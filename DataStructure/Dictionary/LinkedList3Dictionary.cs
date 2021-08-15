using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Dictionary
{
    /// <summary>
    /// 使用单向链表映射
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class LinkedList3Dictionary<Key,Value>:IDictionary<Key,Value>
    {
        private LinkedList3<Key, Value> list;
        public LinkedList3Dictionary() 
        {
            list = new LinkedList3<Key, Value>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public void Add(Key key, Value value)
        {
             list.Add(key,value);
        }

        public bool ContainsKey(Key key)
        {
            return list.Contains(key);
        }

        public Value Get(Key key)
        {
            return list.Get(key);
        }

        public void Remove(Key key)
        {
            list.Remove(key);
        }

        public void Set(Key key, Value newvalue)
        {
            list.Set(key,newvalue);
        }
    }
}
