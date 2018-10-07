using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Creational.Prototype
{
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
