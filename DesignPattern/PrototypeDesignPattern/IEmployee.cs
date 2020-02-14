using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesignPattern
{
    public interface IEmployee
    {
        /// <summary>
        /// protype interface
        /// </summary>
        /// <returns></returns>
        IEmployee Clone();
        string GetDetails();
    }
}
