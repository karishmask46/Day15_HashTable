using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_HashTable
{
    
    class MyMapNode<K, V>
        {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
            {
                this.size = size;
                this.items = new LinkedList<KeyValue<K, V>>[size];
            }
            public void Add(K key, V value)
            {
                int position = GetArrayPosition(key);  // |-5| =5 |3|=3 |-3|=3
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
                KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
                linkedList.AddLast(item);
            }
            
            public V Get(K key)
            {
                int position = GetArrayPosition(key);
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
                foreach (KeyValue<K, V> item in linkedList)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                return default(V);
            }
            // 5-4345 7-8765456 8-8745
            protected int GetArrayPosition(K key)// 5->-7654323456     5->  7654323456 //78-87654568745 
            {
                int position = key.GetHashCode() % size;
                return Math.Abs(position);
            }

            protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
            {
                LinkedList<KeyValue<K, V>> linkedList = items[position];
                if (linkedList == null)
                {
                    linkedList = new LinkedList<KeyValue<K, V>>();
                    items[position] = linkedList;
                }
                return linkedList;
            }
        }
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }   
    
}
