using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    class Cache
    {
        // A list of elements
        public LinkedList<object> ElementList { get; set; }
        // A dictionary which contains the id of the nodes in the list of elements
        public Dictionary<int, LinkedListNode<int>> nodeList { get; set; }
        // Fields to store the maximum capacity of the cache and current filled capacity
        public int MaxCapacity { get; set; }
        public int TotalElements { get; set; }
        // A constructor which requires maximum capacity to be set
        public Cache(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
        }
        // A method to attempt retrieval of an element and which returns true if element is found
        public bool TryGetValue(int key, out int value) // TODO
        {
            value = 0;
            return true;
        }

        public void Clear()
        {
            // TODO - clean 
        }

        public void Add(int key, LinkedListNode<int> value)
        {

        }

    }
}
