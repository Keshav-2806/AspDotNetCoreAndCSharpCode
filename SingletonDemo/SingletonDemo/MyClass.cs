using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    sealed class MyClass
    {
        private MyClass() { }

        private static MyClass instance;
        private static object instanceLock = new object();

        public static MyClass GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MyClass();
                    }         
                }
            }
            return instance;
        }
    }
}
