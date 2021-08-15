using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.Set;

namespace DataStructure.TestHelper
{
    class TestHelper 
    {
        public static long TestStack(IStack<int> stack, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        public static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        public static long TestSet(Set.ISet<string> set, List<string> words)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            foreach (var item in words)
            {
                set.Add(item);
            }
            st.Stop();
            return st.ElapsedMilliseconds;
        }
        public static long TestDictionary(Dictionary.IDictionary<string,int> dic,List<string> words)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            foreach (var item in words)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic.Set(item,dic.Get(item)+1);
                }
            }
            st.Stop();
            return st.ElapsedMilliseconds;
        }
        public static List<string> ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename,FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> words = new List<string>();
            //分词
            while (!sr.EndOfStream)//判断是否达到尾部
            {
                //读取一行字符串并去除头尾的空格
                string contents = sr.ReadLine().Trim();
                int start = FirstCharacterIndex(contents, 0);
                for (int i = start + 1; i < contents.Length; i++)
                {
                    if (i == contents.Length||!Char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start,i-start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents,i);
                        i = start + 1;
                    }
                    else
                    {
                        i++;               
                    }
                }
            }
            fs.Close();
            sr.Close();
            return words;
        }
        private static int FirstCharacterIndex(string s,int start)
        {
            for (int i = start+1; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    return i;
                }
            }
            return s.Length;
        }
    }
}
