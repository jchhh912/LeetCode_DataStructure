using DataStructure.Array;
using DataStructure.BinaryTree;
using DataStructure.Dictionary;
using DataStructure.Set;
using DataStructure.Test;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using static DataStructure.TestHelper.TestHelper;
namespace DataStructure
{
    class Program
    {
      
     
        static void Main(string[] args)
        {
            //红黑树
            RedBlankTree<int> redBlankTree = new RedBlankTree<int>();
            int[] a = { 8, 4, 12, 2,1, 6, 10, 14 };
            for (int i = 0; i < a.Length; i++)
            {
                redBlankTree.Add(a[i]);
            }
            Console.WriteLine(redBlankTree.MaxHeight());

            //二叉查找树 查找 删除 添加 排序
            //int[] a = { 8, 4, 12, 2,1, 6, 10, 14 };
            //BinarySeachTree<int> bst = new BinarySeachTree<int>();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    bst.Add1(a[i]);
            //}
            //bst.PreOrder();         
            //Console.WriteLine();
            //bst.InOrder();
            //Console.WriteLine();
            //bst.PostOrder();
            //Console.WriteLine();
            //bst.LevelOrder();0
            //Console.WriteLine();
            //Console.WriteLine(bst.Max());
            //Console.WriteLine(bst.Min());
            //Console.WriteLine();
            //bst.RemoveMin();
            //bst.RemoveMax();
            //Console.WriteLine();
            //bst.InOrder();
            //Console.WriteLine();
            //Console.WriteLine(bst.Max());
            //Console.WriteLine(bst.Min());
            //Console.WriteLine();
            // bst.Remove(6);
            // bst.InOrder();
            // Console.WriteLine(bst.MaxHeight());

            //链表字典 和 有序数组字典对比
            //Stopwatch st = new Stopwatch();
            //List<string> words = ReadFile("D:\\doc.txt"); 
            //Console.WriteLine(words.Count);
            //LinkedList3Dictionary<string, int> linkedList3Dictionary = new LinkedList3Dictionary<string, int>();
            //SortedArray2Dictionary<string, int> sortedArray2Dictionary = new SortedArray2Dictionary<string, int>();
            //long t1 = TestDictionary(linkedList3Dictionary,words);
            //long t2 = TestDictionary(sortedArray2Dictionary, words);
            //Console.WriteLine(t1);
            //Console.WriteLine(linkedList3Dictionary.Get("in"));
            //Console.WriteLine(linkedList3Dictionary.Count);
            //Console.WriteLine(t2);
            //Console.WriteLine(sortedArray2Dictionary.Get("in"));
            //Console.WriteLine(sortedArray2Dictionary.Count);
            //有序数组集合（二分查找） 和链表集合对比（顺序查找）
            //Stopwatch st = new Stopwatch();
            //List<string> words = ReadFile("D:\\doc.txt");
            //Console.WriteLine(words.Count);
            //LinkedList1Set<string> linkedList1Set = new LinkedList1Set<string>();
            //SortedArray1Set<string> sortedArray1Set = new SortedArray1Set<string>();
            //long t1=TestSet(sortedArray1Set, words);
            //long t2 = TestSet(linkedList1Set, words);
            //Console.WriteLine(t1);
            //Console.WriteLine(linkedList1Set.Count);
            //Console.WriteLine(t2);
            //Console.WriteLine(sortedArray1Set.Count);
            //有序数组
            //int[] arr = { 1, 3, 4, 2, 55, 223, 45, 12, 532, 123, 53123, 124, 4325, 123, 432 };
            //SortedArray1<int> sortedArray1 = new SortedArray1<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sortedArray1.Add(arr[i]);
            //}
            //Console.WriteLine(sortedArray1);
            //Console.WriteLine(sortedArray1.Contains(0));
            //Console.WriteLine(sortedArray1.Min());
            //Console.WriteLine(sortedArray1.Max());
            //Console.WriteLine(sortedArray1.Select(0));
            //Console.WriteLine(sortedArray1.Floor(1));
            //Console.WriteLine(sortedArray1.Ceiling(433));
            //sortedArray1.Remove(55);
            //Console.WriteLine(sortedArray1);

            //Student[] students =
            //{
            //    new Student("小明",180),
            //     new Student("小H",140),
            //      new Student("小D",150)
            //};
            //SortedArray1<Student> s = new SortedArray1<Student>();
            //for (int i = 0; i < students.Length; i++)
            //{
            //    s.Add(students[i]);
            //}
            //Console.WriteLine(s);
            //链表字典 单词字典
            //Stopwatch st1 = new Stopwatch();
            //List<string> words1 = ReadFile("D:\\doc.txt");
            //Console.WriteLine(words1.Count);
            //LinkedList3Dictionary<string,int> linkedList3Dictionary = new LinkedList3Dictionary<string,int>();
            //st1.Start();
            //foreach (var item in words1)
            //{
            //    if (!linkedList3Dictionary.ContainsKey(item))
            //    {
            //        linkedList3Dictionary.Add(item,1);
            //    }
            //    else
            //    {
            //        linkedList3Dictionary.Set(item, linkedList3Dictionary.Get(item) + 1);
            //    }
            //}
            //st1.Stop();
            //Console.WriteLine(linkedList3Dictionary.Count);
            //Console.WriteLine(linkedList3Dictionary.Get("in"));
            //Console.WriteLine(st1.ElapsedMilliseconds);
            //链表集合 单词字典
            //Stopwatch st = new Stopwatch();   
            //List<string> words = ReadFile("D:\\doc.txt");
            //Console.WriteLine(words.Count);
            //LinkedList1Set<string> linkedList1Set = new LinkedList1Set<string>();
            //st.Start();
            //foreach (var item in words)
            //{
            //    linkedList1Set.Add(item);
            //}
            //st.Stop();
            //Console.WriteLine(linkedList1Set.Count);
            //Console.WriteLine(st.ElapsedMilliseconds);
            //链表队列
            //int N = 100000;
            //LinkedList1Queue<int> linkedList1Queue = new LinkedList1Queue<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    linkedList1Queue.Enqueue(i);
            //}
            //Console.WriteLine(linkedList1Queue);
            //linkedList1Queue.Dequeue();
            //Console.WriteLine(linkedList1Queue);
            //LinkedList2Queue<int> linkedList2Queue = new LinkedList2Queue<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    linkedList2Queue.Enqueue(i);
            //}
            //Console.WriteLine(linkedList2Queue);
            //linkedList2Queue.Dequeue();
            //Console.WriteLine(linkedList2Queue);
            //long t1=TestQueue(linkedList1Queue,N);
            //long t2 =TestQueue(linkedList2Queue, N);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);


            //数组队列
            // Array1Queue<int> array1Queue = new Array1Queue<int>();
            // long t1 = TestQueue(array1Queue,N);
            // Console.WriteLine(t1);
            //for (int i = 0; i < 5; i++)
            //{
            //    array1Queue.Enqueue(i);
            //}
            //Console.WriteLine(array1Queue);
            //array1Queue.Dequeue();
            //Console.WriteLine(array1Queue);
            //Console.WriteLine(array1Queue.Peek());
            //循环队列
            //Array2Queue<int> array2Queue = new Array2Queue<int>();
            //long t2 = TestQueue(array2Queue,N);
            //Console.WriteLine(t2);
            //for (int i = 0; i < 5; i++)
            //{
            //    array2Queue.Enqueue(i);
            //}
            //Console.WriteLine(array2Queue);
            //array2Queue.Dequeue();
            //Console.WriteLine(array2Queue);
            //Console.WriteLine(array2Queue.Peek());

            //测试链表栈和数组栈的效率
            //int N = 10000000;
            //Array1Stack<int> array1Stack = new Array1Stack<int>(N);
            //Console.WriteLine(TestStack(array1Stack, N));
            //LinkedList1Stack<int> linkedList1Stack = new LinkedList1Stack<int>();
            //long t2 = TestStack(linkedList1Stack,N);
            //Console.WriteLine(t2);

            //Stack<int> stack = new Stack<int>(N);
            //Stopwatch t = new Stopwatch();
            //t.Start();
            //for (int i = 0; i < N; i++)
            //    stack.Push(i);
            //for (int i = 0; i < N; i++)
            //    stack.Pop();
            //t.Stop();
            //Console.WriteLine(t.ElapsedMilliseconds);
            //链表栈
            //LinkedList1Stack<int> linked = new LinkedList1Stack<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    linked.Push(i);
            //}
            //linked.Pop();
            //Console.WriteLine(linked);
            //Console.WriteLine(linked.Peek());
            //数组栈的应用 =》动态数组实现 受限的线性数据结构
            //Array1Stack<int> stack = new Array1Stack<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    stack.Push(i);
            //}
            //Console.WriteLine(stack);
            ////出栈
            //stack.Pop();
            //Console.WriteLine(stack);
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
            //l.Contains(33);
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
            Console.ReadKey();
        }
    }
}
