using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class MultiDictionary<K,V> : IMultiDictionary<K,V>, IEnumerable<KeyValuePair<K, IEnumerable<V>>>
    {

        internal Dictionary<K, LinkedList<V>> Dictionary = new Dictionary<K, LinkedList<V>>();

        public ICollection<K> Keys => Dictionary.Keys;

        public ICollection<V> Values
        {
            get
            {
                ICollection<V> values = new List<V>();
                foreach (var key in Dictionary.Keys)
                {
                    foreach (var value in Dictionary[key])
                    {
                        values.Add(value);
                    }
                }
                return values;
            }
        }

        public int Count { get; private set; }

        public void Add(K key, V value)
        {
            if (Dictionary.ContainsKey(key))
            { 
                if (Dictionary[key].Contains(value))
                {
                    Console.WriteLine("Dictionary allready contain this value");
                    return;
                }
                else
                {
                    Dictionary[key].AddLast(value);
                }
            }
            else
            {
                Dictionary.Add(key, new LinkedList<V>());
                Dictionary[key].AddLast(value);
            }
            Count++;
        }

        public bool Remove(K key)
        {
            if (Dictionary.ContainsKey(key))
            {
                Count -= Dictionary[key].Count;
            }

            return Dictionary.Remove(key);
        }

        public bool Remove(K key, V value)
        {
            if (Dictionary.ContainsKey(key))
            {
                if (Dictionary[key].Remove(value))
                {
                    Count--;
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            Dictionary.Clear();
            Count = 0;
        }

        public bool ContainsKey(K key)
        {
            return Dictionary.ContainsKey(key);
        }

        public bool ContainsKey(K key, V value)
        {
            return Dictionary.ContainsKey(key) && Dictionary[key].Contains(value);
        }

        public IEnumerator<KeyValuePair<K, IEnumerable<V>>> GetEnumerator()
        {
            var list = new List<KeyValuePair<K, IEnumerable<V>>>();

            foreach (var pair in Dictionary)
            {
                list.Add(new KeyValuePair<K, IEnumerable<V>>(pair.Key, pair.Value));
            }
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Dictionary.GetEnumerator();
        }
    }

  
}
