using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class MemoryCache : ICacheService
    {
        public void Add(string key, object data)
        {
            Console.WriteLine("Memory Cache il eklendi.");
        }

        public object Get(string key)
        {
            Console.WriteLine("Memory Cache il eklendi.");
            return null;
        }

        public bool isExist(string key)
        {
            return false;
        }

        public void Remove(string key)
        {
            Console.WriteLine("Memory Cache il Silindi.");
        }
    }
}
