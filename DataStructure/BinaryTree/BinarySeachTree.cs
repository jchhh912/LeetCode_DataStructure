using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    /// <summary>
    /// 二叉查找树 泛型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BinarySeachTree<T> where T:IComparable<T>
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
        public BinarySeachTree()
        {
            root = null;
            N = 0;
        }
        public int Count { get { return N; } }
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
            }
            cur = new Node(t);
            if (t.CompareTo(pre.t) < 0)
            {
                pre.left = cur;
            }
            else
            {
                pre.right = cur;
            }
            N++;
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
        public void PreOrder() 
        {
            PreOrder(root);
        }
        //递归遍历二叉树 前序便利 先遍历根节点在遍历左节点 再遍历右节点 
        /// <summary>
        /// 前序遍历 根=》左=》右
        /// </summary>
        /// <param name="node"></param>
        private void PreOrder(Node node) 
        {
            if (node==null)
            {
                return;
            }
            Console.WriteLine(node.t);
            PreOrder(node.left);
            PreOrder(node.right);
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        public void InOrder() 
        {
            InOrder(root);
        }
        /// <summary>
        /// 中序遍历 左=》根=》右
        /// </summary>
        /// <param name="node"></param>
        private void InOrder(Node node)
        {
            if (node==null)
            {
                return;
            }
            InOrder(node.left);
            Console.WriteLine(node.t);
            InOrder(node.right);
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PostOrder() 
        {
            PostOrder(root);
        }
        /// <summary>
        /// 后序遍历 左 右 根
        /// </summary>
        /// <param name="node"></param>
        private void PostOrder(Node node)
        {
            if (node==null)
            {
                return;
            }
            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.t);
        }
        /// <summary>
        /// 前序遍历 从树根开始遍历
        /// </summary>
        public void LevelOrder() 
        {
            Queue<Node> que = new Queue<Node>();
            //加入队列
            que.Enqueue(root);
            while (que.Count!=0)
            {
                //取出队列
                Node cur = que.Dequeue();
                Console.WriteLine(cur.t);
                if (cur.left!=null)
                {
                    que.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    que.Enqueue(cur.right);
                }
            }
        }
        /// <summary>
        /// 查找最小值
        /// </summary>
        /// <returns></returns>
        public T Min() 
        {
            if (IsEmpty)
            {
                throw new ArgumentException("空树");
            }
            return Min(root).t;
        }
        public T Max() 
        {
            if (IsEmpty)
            {
                throw new ArgumentException("空树");
            }
            return Max(root).t;
        }
        private Node Min(Node node) 
        {
            if (node.left==null)
            {
                return node;
            }
            return Min(node.left);
        }
        private Node Max(Node node) 
        {
            if (node.right==null)
            {
                return node;
            }
            return Max(node.right);
        }
        public T RemoveMin() 
        {
            T ret= Min();
            //更新根
            root = RemoveMin(root);
            return ret;
        }
        private Node RemoveMin(Node node)
        {   
            //判断到最小值了没
            if (node.left==null)
            {
                //删除一个 然后返回他的右节点
                N--;
                return node.right;
            }
            //没找到就 继续递归 寻找最小值
            node.left=RemoveMin(node.left);
            return node;
        }
        public T RemoveMax() 
        {
            T ret = Max();
            root = RemoveMax(root);
            return ret;
        }
        private Node RemoveMax(Node node) 
        {
            if (node.right==null)
            {
                N--;
                return node.left;
            }
            node.right = RemoveMax(node.right);
            return node;
        }
        public void Remove(T t)
        {
          root=Remove(root,t);
        }
        private Node Remove(Node node,T t) 
        {
            if (node == null)
            {
                return null;
            }
            if (t.CompareTo(node.t)<0)
            {
                node.left=Remove(node.left,t);
                return node;
            }
            else if (t.CompareTo(node.t)>0)
            {
                node.right = Remove(node.right, t);
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
                pre.right=RemoveMin(node.right);//将删除后的右节点 连接到当前
                pre.left = node.left; //再替换当前节点 
                return pre;
            }
        }

        public int MaxHeight() 
        {
            return MaxHeight(root);
        }
        private int MaxHeight(Node node)
        {
            if (node==null)
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
