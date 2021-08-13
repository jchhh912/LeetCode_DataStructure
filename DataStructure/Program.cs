using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            //栈的应用 =》动态数组实现 受限的线性数据结构
            Array1Stack<int> stack = new Array1Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine(stack);
            //出栈
            stack.Pop();
            Console.WriteLine(stack);
            //链表
            //LinkedList1<int> l = new LinkedList1<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    l.AddFirst(i);
            //    Console.WriteLine(l);
            //}
            //l.AddLast(22);
            //Console.WriteLine(l);
            //l.Add(2, 999);
            //Console.WriteLine(l);
            //l.Set(2, 333);
            //Console.WriteLine(l);

            ////9->8->333->7->6->5->4->3->2->1->0->22->Null
            //l.Remove(333);
            //l.RemoveAt(3);
            //l.RemoveFirst();
            //l.RemoveLast();
            //l.Remove(0);

            //Console.WriteLine(l);

            //数组 泛型 动态数组 静态数组
            //int[] N = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array1<int> a = new Array1<int>();
            //for (int i = 0; i < N.Length; i++)
            //{
            //    a.AddLast(N[i]);
            //}
            //Console.WriteLine(a);
            //string[] s = { "a", "b", "c", "d" };
            //Array1<string> a2 = new Array1<string>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    a2.AddLast(s[i]);
            //}
            //Console.WriteLine(a2);
        }
    }
}
