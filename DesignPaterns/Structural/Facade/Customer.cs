using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Structural.Facade
{
    public class Customer
    {
        private string _name;

        // Constructor

        public Customer(string name)
        {
            this._name = name;
        }

        // Gets the name

        public string Name
        {
            get { return _name; }
        }
    }
}
