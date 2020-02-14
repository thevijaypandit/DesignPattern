using DesignPattern.SingletonDesignPattern;
using System;

namespace DesignPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            #region singleton
            Singleton.GetInstance.Show();
            Singleton.GetInstance.Show();
            Singleton.GetInstance.Show();
            #endregion
            #region factory pattern
            #endregion
            Console.ReadKey();
        }
    }
}
