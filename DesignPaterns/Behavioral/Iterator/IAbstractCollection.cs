using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Iterator
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
