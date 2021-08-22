using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash
{
    class HashST_Set<Key>:Set.ISet<Key>
    {
        private HashST<Key> hashST;

        public int Count => hashST.Count;

        public bool IsEmpty => hashST.IsEmpty;

        public HashST_Set(int M)
        {
            hashST = new HashST<Key>(M);
        }
        public HashST_Set() 
        {
            hashST = new HashST<Key>();
        }

        public void Add(Key key)
        {
            hashST.Add(key);
        }

        public void Remove(Key key)
        {
            hashST.Remove(key);
        }

        public bool Contains(Key key)
        {
          return  hashST.Contains(key);
        }
    }
}
