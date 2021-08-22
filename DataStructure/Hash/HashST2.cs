using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash
{
    class HashST2<Key,Value>
    {  //基于链表的数组
        private LinkedList3<Key,Value>[] hashtable;
        //数组元素数量
        private int N;
        //数组容量
        private int M;
        public HashST2(int M)
        {
            this.M = M;
            N = 0;
            hashtable = new LinkedList3<Key,Value>[M];
            //对数组索引每个位置都开一条链表
            for (int i = 0; i < M; i++)
            {
                hashtable[i] = new LinkedList3<Key,Value>();
            }
        }
        public HashST2() : this(97) { }
        public int Count => N;
        public bool IsEmpty => N == 0;
        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }
        public void Add(Key key,Value value)
        {
            LinkedList3<Key,Value> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                list.Set(key,value);
            }
            else
            {
                list.Add(key,value);
                N++;
            }
        }
        public void Remove(Key key)
        {
            LinkedList3<Key,Value> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                N--;
            }
        }
        public bool Contains(Key key)
        {
            LinkedList3<Key,Value> list = hashtable[Hash(key)];
            return list.Contains(key);
        }
        public Value Get(Key key)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            return list.Get(key);
        }
        public void Set(Key key,Value newValue)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            list.Set(key, newValue);
        }
    }
}
