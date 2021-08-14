using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Dictionary
{
    /// <summary>
    /// 字典接口
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    interface IDictionary<Key,Value>
    {
        void Add(Key key, Value value);
        void Remove(Key key);
        bool ContainsKey(Key key);
        Value Get(Key key);
        void Set(Key key,Value newvalue);
        int Count { get; }
        bool IsEmpty { get; }
    }
}
