using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Observer
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        // Constructor

        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
