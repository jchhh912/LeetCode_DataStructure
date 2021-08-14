using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Set
{
    /// <summary>
    /// 集合接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISet<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Add(T t);
        void Remove(T t);
        bool Contains(T t);
    }
}
