using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Set
{
    /// <summary>
    /// 单向链表集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList1Set<T>:ISet<T> 
    {
        private LinkedList1<T> list;
        public LinkedList1Set() {

            list = new LinkedList1<T>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public void Add(T t)
        {
            if (!list.Contains(t))
            {
                list.AddFirst(t);
            }
        }

        public bool Contains(T t)
        {
            return list.Contains(t);
        }

        public void Remove(T t)
        {
            list.Remove(t);
        }
    }
}
