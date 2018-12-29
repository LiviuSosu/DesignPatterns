using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Iterator
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
