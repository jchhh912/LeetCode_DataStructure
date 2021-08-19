using System;
using System.Collections.Generic;
using DataStructure.Set;

namespace DataStructure.BinaryTree
{
    /// <summary>
    /// 二叉查找树实现集合
    /// </summary>
    class BinarySeachTreeSet<T>: Set.ISet<T> where T:IComparable<T>
    {
        private BinarySeachTree<T> bst;
        public BinarySeachTreeSet() 
        {
            bst = new BinarySeachTree<T>();
        }

        public int Count => bst.Count;

        public bool IsEmpty => bst.IsEmpty;

        public void Add(T t)
        {
            bst.Add1(t);
        }

        public bool Contains(T t)
        {
           return bst.Contains(t);
        }

        public void Remove(T t)
        {
            bst.Remove(t);
        }
        public int MaxHeight() 
        {
            return bst.MaxHeight();
        }
    }
}
