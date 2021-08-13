using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 队列接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
     interface IQueue<T>
    {
        //队列数量
        int Count { get; }
        //队列是否为空
        bool IsEmpty { get; }
        //入队
        void Enqueue(T t);
        //出队
        T Dequeue();
        //查询队首
        T Peek();
    }
}

