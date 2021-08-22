using DataStructure.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    class RedBlankTree2Dictionary<Key,Value>:Dictionary.IDictionary<Key,Value> where Key: IComparable<Key>
    {
        private RedBlankTree2<Key, Value> RedBlankTree2;
        public RedBlankTree2Dictionary() 
        {
            RedBlankTree2 = new RedBlankTree2<Key, Value>();
        }

        public int Count => RedBlankTree2.Count;

        public bool IsEmpty => RedBlankTree2.IsEmpty;

        public void Add(Key key, Value value)
        {
            RedBlankTree2.Add(key,value);
        }

        public bool ContainsKey(Key key)
        {
            return RedBlankTree2.Contais(key);
        }

        public Value Get(Key key)
        {
            return RedBlankTree2.GetValue(key);
        }

        public void Remove(Key key)
        {
            Console.WriteLine("等待实现");
        }

        public void Set(Key key, Value newvalue)
        {
            RedBlankTree2.Set(key,newvalue);
        }
    }
}
