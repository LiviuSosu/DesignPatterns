using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Visitor
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
