using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SingletonDesignPattern
{
    public class Singleton
    {
        // .NET guarantees thread safety for static initialization
        private static Singleton singletonInstance = null;
        // Lock synchronization object
        private static object syncLock = new object();
        public string Name { get; set; }
        public string IP { get; set; }
        private Singleton()
        {
            //To DO: Remove below line
            Console.WriteLine("Singleton Intance");
            this.Name = "Server1";
            this.IP = "192.168.3.222";
        }
        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", Name,IP);
        }
        public static Singleton GetInstance
        {
            //get
            //{
            //    // Support multithreaded applications through
            //    // 'Double checked locking' pattern which (once
            //    // the instance exists) avoids locking each
            //    // time the method is invoked
            //    lock (syncLock)
            //    {
            //        if (Singleton.instance == null)
            //            Singleton.instance = new Singleton();

            //        return Singleton.instance;
            //    }
            //}
            get
            {
                lock (syncLock)
                {
                    if (singletonInstance == null)
                    {
                        singletonInstance = new Singleton();
                    }
                    return singletonInstance;
                }
            }
        }
    }
}
