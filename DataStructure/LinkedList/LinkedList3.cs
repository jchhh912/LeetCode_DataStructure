using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    /// <summary>
    /// 单向链表实现映射字典 
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class LinkedList3<Key,Value>
    {
        private class Node 
        {
            public Key key;
            public Value value;
            public Node next;
            public Node(Key key,Value value,Node next) 
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
            public override string ToString()
            {
                return key.ToString() + ":" + value.ToString();
            }
        }
        private Node head;
        private int N;
        public LinkedList3() 
        {
            head = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        private Node GetNode(Key key) 
        {
            Node cur = head;
            while (cur!=null)
            {
                if (cur.key.Equals(key))
                {
                    return cur;
                }
                cur = cur.next;
            }
            return null;
        }
        public void Add(Key key,Value value) 
        {
            Node node = GetNode(key);
            if (node==null)
            {
                head = new Node(key,value,head);
                N++;
            }
            else
            {
                node.value = value;
            }
        }
        public bool Contains(Key key)
        {
            return GetNode(key) != null;
        }
        public Value Get(Key key)
        {
            Node node = GetNode(key);
            if (node == null)
            {
                throw new ArgumentException($"键：{key}不存在");
            }
            else
            {
                return node.value;
            }
        }
        public void Set(Key key,Value newvalue)
        {
            Node node = GetNode(key);
            if (node==null)
            {
                throw new ArgumentException($"键：{key}不存在");
            }
            else
            {
                node.value = newvalue;
            }
        }
        public void Remove(Key key)
        {
            if (head == null)
            {
                return;
            }
            if (head.key.Equals(key))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;
                while (cur != null)
                {
                    //如果找到就跳出
                    if (cur.key.Equals(key))
                    {
                        break;
                    }
                    //保存上一节点的指向
                    pre = cur;
                    //继续下一个节点
                    cur = cur.next;
                }
                if (cur != null)
                {
                    //找到当前节点后 跨过当前节点获取目标的指针指向
                    pre.next = pre.next.next;
                    N--;
                }

            }

        }
    }
}
