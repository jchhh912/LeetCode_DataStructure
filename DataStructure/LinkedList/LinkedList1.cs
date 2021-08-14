using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 单向链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList1<T>
    {
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
        //链表的头
        private Node head;
        //链表的数量
        private int N;
        /// <summary>
        /// 初始化构造函数
        /// </summary>
        public LinkedList1() 
        {
            head = null;
            N = 0;
        }
        public int Count
        {
            get{ return N; }
        }
        public bool IsEmpty 
        {
            get { return N == 0; }
        }
        public void Add(int index, T t)
        {
            if (index<0||index>N)
            {
                throw new ArgumentException("非法索引");
            }
            if (index==0)
            {
                Node node = new Node(t); //创建新节点
                //node.next = head;  //首节点下一引用默认为空
                //head = node; //头节点设置为传入的元素
                //head = new Node(t,head); //更新链表

                head = new Node(t,head);
            }
            else
            {
                //往中间或尾部插入
                Node pre = head; //获取头节点
                //从头节点开始遍历到插入值的前一位，获取前一位的指针地址
                for (int i = 0; i < index-1; i++)
                {
                    //获取下一个节点的指针
                    pre = pre.next;
                }
                //创建新节点T
                //Node node = new Node(t);
                ////将上一指针的指向地址保存到当前指针的地址 确保链接状态 ==插入  1 2 3    在2 后插入5  1 =》2 =》5 =》 =》3
                //node.next = pre;
                ////将上一节点的指向地址更换为当前节点
                //pre.next = node;
                //上面三段可以用一句代码表示
                pre.next = new Node(t,pre.next);
            }
            //元素个数添加
            N++;
        }
        /// <summary>
        /// 在链表头部添加
        /// </summary>
        /// <param name="t"></param>
        public void AddFirst(T t)
        {
            Add(0,t);
        }
        /// <summary>
        /// 在链表尾部添加
        /// </summary>
        /// <param name="t"></param>
        public void AddLast(T t) {
            Add(N,t);
        }
        /// <summary>
        /// 获取指定位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            Node cur = head;  // 头部
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.t;
        }
        /// <summary>
        /// 获取头部的元素
        /// </summary>
        /// <returns></returns>
        public T GetFirst() 
        {
            return  Get(0);
        }
        /// <summary>
        /// 获取尾部的元素
        /// </summary>
        /// <returns></returns>
        public T GetLast() 
        {
            return Get(N-1);
        }
        /// <summary>
        /// 修改指定节点的元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="t">元素</param>
        public void Set(int index,T t) 
        {
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.t = t;
        }
        /// <summary>
        /// 是否存在元素
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Contains(T t)
        {
            Node cur = head;
            while (cur!=null)
            {
                if (cur.t.Equals(t))
                {
                    return true;
                }
                cur = cur.next;
            }
            return false;
        }
        /// <summary>
        /// 删除指定位置的节点
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public T RemoveAt(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            //删除首节点
            if (index==0)
            {
                //保存首节点
                Node delNode = head;
                //将首节点改为后一节点的指向
                head = head.next;
                N--;
                return delNode.t;
            }
            //删除中间或尾部的节点
            else
            {
                Node pre = head;
                //-1 是因为只需获取到前一节点就可以知道后一节点的指向
                for (int i = 0; i < index-1; i++)
                {
                    //遍历节点指针获取到 指定节点的前一位的指针
                    pre = pre.next;
                }
                //获取到原来指针指向的的地址 保存下来
                Node delNode = pre.next;
                //将被删除的节点的前一位的指针的地址改为 被删除的节点的下一位 
                pre.next = delNode.next;
                N--;
                return delNode.t;
            }
        }
        /// <summary>
        /// 删除首位
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst() 
        {
            return RemoveAt(0);
        }
        /// <summary>
        /// 删除最后一个节点
        /// </summary>
        /// <returns></returns>
        public T RemoveLast() 
        {
            return RemoveAt(N-1);
        }
        public void Remove(T t) 
        {
            if (head==null)
            {
                return;
            }
            if (head.t.Equals(t))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;
                while (cur!=null)
                {
                    //如果找到就跳出
                    if (cur.t.Equals(t))
                    {
                        break;
                    }
                    //保存上一节点的指向
                    pre = cur;
                    //继续下一个节点
                    cur = cur.next;
                }
                if (cur!=null)
                {
                    //找到当前节点后 跨过当前节点获取目标的指针指向
                    pre.next = pre.next.next;
                    N--;
                }
            
            }
        
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur!=null)
            {
                res.Append(cur+"->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }

    }
}
