using DataStructure.Set;
using System;
using System.Collections.Generic;

namespace DataStructure.BinaryTree
{
    /// <summary>
    /// 实现集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class RedBlankTreeSet<T>:Set.ISet<T> where T:IComparable<T>
    {
        private RedBlankTree<T> redBlankTree;
        public RedBlankTreeSet() 
        {
            redBlankTree = new RedBlankTree<T>();
        }

        public int Count => redBlankTree.Count;

        public bool IsEmpty => redBlankTree.IsEmpty;

        public void Add(T t)
        {
            redBlankTree.Add(t);
        }

        public bool Contains(T t)
        {
            return redBlankTree.Contains(t);
        }

        public void Remove(T t)
        {
            Console.WriteLine("带实现");
        }
        public int MaxHeight() 
        {
            return redBlankTree.MaxHeight();
        }
    }
}
