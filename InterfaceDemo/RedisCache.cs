using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class RedisCache : ICacheService
    {
        public void Add(string key, object data)
        {
           Console.WriteLine("Redis ile eklendi.");
        }

        public object Get(string key)
        {
            Console.WriteLine("Redis ile getirildi.");
            return null;
        }

        public bool isExist(string key)
        {
            return false;
        }

        public void Remove(string key)
        {
            Console.WriteLine("Redis ile silindi.");
        }
    }
}
