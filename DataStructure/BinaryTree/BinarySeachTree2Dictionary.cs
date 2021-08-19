using DaKeyaSKeyrucKeyure.BinaryKeyree;
using System;
using System.Collections.Generic;
using DataStructure.Dictionary;

namespace DataStructure.BinaryTree
{
    /// <summary>
    /// 二叉查找树实现的字典
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class BinarySeachTree2Dictionary<Key,Value>: DataStructure.Dictionary.IDictionary<Key, Value> where Key:IComparable<Key>
    {
        private BinarySheachTree2<Key, Value> bst;
        public BinarySeachTree2Dictionary() 
        {
            bst = new BinarySheachTree2<Key, Value>();
        }

        public int Count => bst.Count;

        public bool IsEmpty => bst.IsEmpty;

        public void Add(Key key, Value value)
        {
            bst.Add(key,value);
        }

        public bool ContainsKey(Key key)
        {
            return bst.Contais(key);
        }

        public Value Get(Key key)
        {
            return bst.GetValue(key);
        }

        public void Remove(Key key)
        {
            bst.Remove(key);
        }

        public void Set(Key key, Value newvalue)
        {
            bst.Set(key,newvalue);
        }
    }
}
