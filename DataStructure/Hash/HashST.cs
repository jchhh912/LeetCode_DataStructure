using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    class HashST<Key>
    {
        //基于链表的数组
        private LinkedList1<Key>[] hashtable;
        //数组元素数量
        private int N;
        //数组容量
        private int M;
        public HashST(int M)
        {
            this.M = M;
            N = 0;
            hashtable = new LinkedList1<Key>[M];
            //对数组索引每个位置都开一条链表
            for (int i = 0; i < M; i++)
            {
                hashtable[i] = new LinkedList1<Key>();
            }
        }
        public HashST() : this(97) { }
        public int Count => N;
        public bool IsEmpty => N == 0;
        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }
        public void Add(Key key)
        {
            LinkedList1<Key> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                return;
            }
            else
            {
                list.AddFirst(key);
                N++;
            }
        }
        public void Remove(Key key)
        {
            LinkedList1<Key> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                N--;
            }
        }
        public bool Contains(Key key)
        {
            LinkedList1<Key> list = hashtable[Hash(key)];
            return list.Contains(key);
        }
    }
}
