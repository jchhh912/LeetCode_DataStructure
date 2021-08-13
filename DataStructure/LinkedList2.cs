using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList2<T>
    {
        /// <summary>
        /// 节点类
        /// </summary>
        private class Node
        {
            public T t;
            public Node next;
            /// <summary>
            /// 记录下一个节点的引用
            /// </summary>
            /// <param name="t">元素</param>
            /// <param name="next">下一个节点的引用</param>
            public Node(T t, Node next)
            {
                this.t = t;
                this.next = next;
            }
            /// <summary>
            /// 查找下个引用
            /// </summary>
            /// <param name="t">元素</param>
            public Node(T t)
            {
                this.t = t;
                this.next = null;
            }
            public override string ToString()
            {
                return t.ToString();
            }
        }
        private Node head;
        private Node tail;
        private int N;
        public LinkedList2() 
        {
            head = null;
            tail = null;
            N = 0;
        }
        public int Count{ get{ return N; } }
        public bool IsEmpty { get { return N == 0; } }
        public void AddLast(T t) 
        {
            Node node = new Node(t);
            if (IsEmpty)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }
        public T RemoveFirst() 
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }
            T t = head.t;
            head = head.next;
            N--;
            if (head==null)
            {
                tail = null;
            }
            return t;
        }
        public T GetFirst() 
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }
            return head.t;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }
    }
}
