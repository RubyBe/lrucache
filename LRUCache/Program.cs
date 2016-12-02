using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    class Program
    {
        // A program which implements a less recently used cache
        static void Main(string[] args)
        {
            LRU newLRU = new LRUCache.LRU(5);

            string input = "A";
            for(int i = 0; i < 7; i++)
            {
                
                newLRU.Add(i, input);
                input += input;
            }

            string value;
            newLRU.TryGetValue(2, out value);

            Console.ReadLine();
        }
    }
}
