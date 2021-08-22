using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    /// <summary>
    /// 实现映射
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class RedBlankTree2<Key,Value> where Key : IComparable<Key>
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public Key key;
            public Value value;
            public Node left;
            public Node right;
            public bool color;
            public Node(Key key,Value value)
            {
                this.key = key;
                this.value = value;
                left = null;
                right = null;
                color = Red;
            }
        }
        private Node root;
        private int N;
        public RedBlankTree2()
        {
            root = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        /// <summary>
        /// 判断是否为红节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private bool IsRed(Node node)
        {
            if (node == null)
            {
                return Black;
            }
            return node.color;
        }
        //   node               x
        //  /   \             /   \
        //T1     x          node   T3
        //      / \         /  \   
        //     T2 T3       T1  T2
        /// <summary>
        /// 右节点为红色 左旋转
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = Red;
            return x;

        }
        /// <summary>
        /// 左右均为红色 反转颜色
        /// </summary>
        /// <param name="node"></param>
        private void FlipColors(Node node)
        {
            node.color = Red;
            node.left.color = Black;
            node.right.color = Black;
        }
        //     node               x
        //    /   \             /   \
        //   x     T2          T3   node
        //  /\                      /  \   
        // T3 T1                   T1  T2
        /// <summary>
        /// 连续两个红链接  右旋转
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node RightRoatate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = Red;
            return x;
        }
        /// <summary>
        /// 往红黑树中添加元素 递归实现  
        /// </summary>
        /// <param name="t"></param>
        public void Add(Key key,Value value)
        {
            root = Add(root, key,value);
            root.color = Black;
        }
        //以node为根的树中添加元素t，添加后返回根节点node
        private Node Add(Node node, Key key,Value value)
        {
            if (node == null)
            {
                N++;
                return new Node(key,value);//默认为红节点
            }
            if (key.CompareTo(node.key) < 0)
            {
                node.left = Add(node.left, key,value);
            }
            else if (key.CompareTo(node.key) > 0)
            {
                node.right = Add(node.right, key,value);
            }
            else  //key 已存在
            {
                node.value = value;
            }
            //维护红黑树
            //1.如果出现右子节点为红色 左子节点为黑色 进行左旋转
            if (IsRed(node.right) && !IsRed(node.left))
            {
                node = LeftRotate(node);
            }
            //2.如果出现连续左子节点为红色 进行右旋转
            if (IsRed(node.left) && IsRed(node.left.left))
            {
                node = RightRoatate(node);
            }
            //3.如果出现左右子节点都为红色 进行颜色翻转
            if (IsRed(node.left) && IsRed(node.right))
            {
                FlipColors(node);
            }
            return node;
        }
        /// <summary>
        /// 获取key 的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private Node GetNode(Node node, Key key)
        {
            if (node == null)
            {
                return null;
            }
            if (key.Equals(node.key))
            {
                return node;
            }
            else if (key.CompareTo(node.key) < 0)
            {
                return GetNode(node.left, key);
            }
            else  // >0
            {
                return GetNode(node.right, key);
            }
        }
        public bool Contais(Key key)
        {
            return GetNode(root, key) != null;
        }
        /// <summary>
        /// 根据key获取value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Value GetValue(Key key)
        {
            Node node = GetNode(root, key);
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
            Node node = GetNode(root, key);
            if (node == null)
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
