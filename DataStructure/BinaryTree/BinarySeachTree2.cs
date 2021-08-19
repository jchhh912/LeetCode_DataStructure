

using System;
using System.Collections.Generic;

namespace DaKeyaSKeyrucKeyure.BinaryKeyree
{
    /// <summary>
    /// 基于二叉查找树实现键值对   映射
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class BinarySheachTree2<Key,Value> where Key : IComparable<Key>
    {
        private class Node
        {
            public Key Key;
            public Value value;
            public Node left;
            public Node right;
            public Node(Key Key,Value value)
            {
                this.Key = Key;
                this.value = value;
                left = null;
                right = null;
            }
        }
        private Node root;
        private int N;
        public BinarySheachTree2()
        {
            root = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        /// <summary>
        /// 使用递归方法  
        /// </summary>
        /// <param name="Key"></param>
        public void Add(Key key,Value value)
        {
            root = Add(root, key,value);
        }
        //以node为根的树中添加元素Key，添加后返回根节点node
        private Node Add(Node node, Key key,Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key,value);
            }
            if (key.CompareTo(node.Key) < 0)
            {
                node.left = Add(node.left, key,value);
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                node.right = Add(node.right, key,value);
            }
            else
            {
                //如果已经存在
                node.value = value;
            }
            return node;
        }
        /// <summary>
        /// 查找最小值
        /// </summary>
        /// <returns></returns>
        public Key Min()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("空树");
            }
            return Min(root).Key;
        }
        public Key Max()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("空树");
            }
            return Max(root).Key;
        }
        private Node Min(Node node)
        {
            if (node.left == null)
            {
                return node;
            }
            return Min(node.left);
        }
        private Node Max(Node node)
        {
            if (node.right == null)
            {
                return node;
            }
            return Max(node.right);
        }
        public Key RemoveMin()
        {
            Key reKey = Min();
            //更新根
            root = RemoveMin(root);
            return reKey;
        }
        private Node RemoveMin(Node node)
        {
            //判断到最小值了没
            if (node.left == null)
            {
                //删除一个 然后返回他的右节点
                N--;
                return node.right;
            }
            //没找到就 继续递归 寻找最小值
            node.left = RemoveMin(node.left);
            return node;
        }
        public Key RemoveMax()
        {
            Key reKey = Max();
            root = RemoveMax(root);
            return reKey;
        }
        private Node RemoveMax(Node node)
        {
            if (node.right == null)
            {
                N--;
                return node.left;
            }
            node.right = RemoveMax(node.right);
            return node;
        }
        public void Remove(Key Key)
        {
            root = Remove(root, Key);
        }
        private Node Remove(Node node, Key Key)
        {
            if (node == null)
            {
                return null;
            }
            if (Key.CompareTo(node.Key) < 0)
            {
                node.left = Remove(node.left, Key);
                return node;
            }
            else if (Key.CompareTo(node.Key) > 0)
            {
                node.right = Remove(node.right, Key);
                return node;
            }
            else
            {
                if (node.left == null)
                {
                    return node.right;
                }
                if (node.right == null)
                {
                    return node.left;
                }
                //要删除的节点左右都有子节点
                //找到比待删除的节点大的最小节点，既是右子树中的最小节点
                //替换当前节点
                Node pre = Min(node.right);//找出当前最小子节点
                pre.right = RemoveMin(node.right);//将删除后的右节点 连接到当前
                pre.left = node.left; //再替换当前节点 
                return pre;
            }
        }
        /// <summary>
        /// 获取key 的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private Node GetNode(Node node,Key key)
        {
            if (node==null)
            {
                return null;
            }
            if (key.Equals(node.Key))
            {
                return node;
            }
            else if (key.CompareTo(node.Key)<0)
            {
                return GetNode(node.left,key);
            }
            else  // >0
            {
                return GetNode(node.right,key);
            }
        }
        public bool Contais(Key key)
        {
            return GetNode(root,key)!=null;
        }
        /// <summary>
        /// 根据key获取value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Value GetValue(Key key) 
        {
            Node node = GetNode(root,key);
            if (node == null)
            {
                throw new ArgumentException($"{key}不存在,无法获取");
            }
            else
            {
                return node.value;
            }
        }
        public void Set(Key key, Value newValue) 
        {
            Node node = GetNode(root,key);
            if (node==null)
            {
                throw new ArgumentException($"{key}不存在,无法更改");
            }
            else
            {
                node.value = newValue;
            }
        }

    }
}
