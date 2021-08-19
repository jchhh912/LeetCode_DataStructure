using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    class RedBlankTree<T> where T : IComparable<T>
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public T t;
            public Node left;
            public Node right;
            public bool color;
            public Node(T t)
            {
                this.t = t;
                left = null;
                right = null;
                color = Red;
            }
        }
        private Node root;
        private int N;
        public RedBlankTree()
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
        public void Add(T t)
        {
            root = Add(root, t);
            root.color = Black;
        }
        //以node为根的树中添加元素t，添加后返回根节点node
        private Node Add(Node node, T t)
        {
            if (node == null)
            {
                N++;
                return new Node(t);//默认为红节点
            }
            if (t.CompareTo(node.t) < 0)
            {
                node.left = Add(node.left, t);
            }
            else if (t.CompareTo(node.t) > 0)
            {
                node.right = Add(node.right, t);
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
        public bool Contains(T t)
        {
            return Contains(root, t);
        }
        /// <summary>
        /// 以nood为根节点查看树是否包含元素t  递归查找
        /// </summary>
        /// <param name=""></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool Contains(Node node, T t)
        {
            if (node == null)
            {
                return false;
            }
            if (t.CompareTo(node.t) == 0)
            {
                return true;
            }
            else if (t.CompareTo(node.t) < 0)
            {
                return Contains(node.left, t);
            }
            else
            {
                //t.CompareTo(node.t)>0
                return Contains(node.right, t);
            }
        }
        public int MaxHeight()
        {
            return MaxHeight(root);
        }
        private int MaxHeight(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            //int l = MaxHeight(node.left);
            //int r = MaxHeight(node.right);
            //return Math.Max(l, r) + 1;
            return Math.Max(MaxHeight(node.left), MaxHeight(node.right)) + 1;
        }
    }
}
