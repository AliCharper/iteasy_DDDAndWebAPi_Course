using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonObject
    {
        private static SingletonObject? instance;

        public static SingletonObject GetInstance()
        {
            if (instance is null)
            {
                var random = new Random();
                instance = new SingletonObject(random.Next());
            }

            return instance;
        }

        private SingletonObject(int data)
        {
            Data = data;
        }

        public int Data { get; private set; }
    }
}
