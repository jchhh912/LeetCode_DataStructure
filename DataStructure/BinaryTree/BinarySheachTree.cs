using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    class BinarySheachTree<T> where T:IComparable<T>
    {
        private class Node {
            public T t;
            public Node left;
            public Node right;
            public Node(T t)
            {
                this.t=t;
                left = null;
                right = null;
            }
        }
        private Node root;
        private int N;
        public BinarySheachTree()
        {
            root = null;
            N = 0;
        }
        public int Cont { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        /// <summary>
        /// 非递归方法
        /// </summary>
        public void Add(T t) 
        {
            if (root==null)
            {
                root = new Node(t);
                N++;
                return;
            }
            Node pre = null;
            Node cur = root;
            while (cur!=null)
            {
                if (t.CompareTo(cur.t)==0)
                {
                    return;
                }
                pre = cur;
                if (t.CompareTo(cur.t)<0)
                {
                    cur = cur.left;
                }
                else
                {
                    cur = cur.right;
                }
                cur = new Node(t);
                if (t.CompareTo(pre.t)<0)
                {
                    pre.left = cur;
                }
                else
                {
                    pre.right = cur;
                }
                N++;
            }
        }
       /// <summary>
       /// 使用递归方法  
       /// </summary>
       /// <param name="t"></param>
        public void Add1(T t) 
        {
            root=Add(root,t);
        }
        //以node为根的树中添加元素t，添加后返回根节点node
        private Node Add(Node node, T t)
        {
            if (node==null)
            {
                N++;
                return new Node(t);
            }
            if (t.CompareTo(node.t) < 0)
            {
                node.left = Add(node.left, t);
            }
            else if(t.CompareTo(node.t)>0)
            {
                node.right = Add(node.right,t);
            }
            return node;
        }
        public bool Contains(T t)
        {
            return Contains(root,t);
        }
        /// <summary>
        /// 以nood为根节点查看树是否包含元素t  递归查找
        /// </summary>
        /// <param name=""></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool Contains(Node node, T t)
        {
            if (node==null)
            {
                return false;
            }
            if (t.CompareTo(node.t) == 0)
            {
                return true;
            }
            else if (t.CompareTo(node.t)<0)
            {
              return Contains(node.left,t);
            }
            else
            {
                //t.CompareTo(node.t)>0
                return Contains(node.right,t);
            }

        }
    }
}
