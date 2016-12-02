using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    class LRU
    {
        private int _MaxCapacity; // Determines maximum number of elements in list
        private int _Size = 0; // Stores number of elements in list
        // A linked list containing a list of elements to be sort by most recently used
        LinkedList<string> listElements = new LinkedList<string>();
        // A dictionary to hold keys of each element of the array, and the value of each element in a node
        Dictionary<int, LinkedListNode<string>> dictElements = new Dictionary<int, LinkedListNode<string>>();
        // A list of nodes for the dictionary
        LinkedListNode<string> Node = new LinkedListNode<string>("First");

        public LRU(int maxCapacity)
        {
            _MaxCapacity = maxCapacity;
        }

        // A method that attempts to retrieve an element given a key; if found will move it to the most recently used item and will return true
        public bool TryGetValue(int key, out string value)
        {
            if (dictElements.ContainsKey(key))
            {
                value = dictElements[key].Value;
                // TODO - move to most recently used
                return true;
            }
            value = "";
            return false;
        }

        // A method to add a new value to the list, and a corresponding key/value to the dictionary
        public void Add(int key, string value)
        {
            // First check to make sure key doesn't already exist
            if (dictElements.ContainsKey(key))
            {
                throw new Exception("Key already exists");
            }
            else
            {
                // Ensure that the list is not at maximum capacity
                if (_Size == _MaxCapacity)
                {
                    // Remove the least used item in the list
                    string removeValue = listElements.Last.Value;
                    // Remove the least used item in the dictionary
                    int removeKey = dictElements.FirstOrDefault(s => s.Value.Value.Contains(removeValue)).Key;
                    //removeKey = dictElements.Where(p => p.Value == value).Select(p => p.Key).FirstOrDefault();
                    listElements.RemoveLast();
                }

                // Now add the newest element to the list and dictionary
                listElements.AddFirst(value);
                if (Node.Next == null)
                {
                    Node.Value = value;
                }
                else
                {
                    Node.Next.Value = Node.Value;
                    Node.Value = value;
                }
                dictElements.Add(key, Node);

                // Track the number of elements in the list
                _Size++;
                return;
            }
        }

        // A method to clear out everything (for unit testing)
        public void Clear()
        {
            listElements.Clear();
            dictElements.Clear();
            _Size = 0;
        }
    }
}
