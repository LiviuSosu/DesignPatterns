using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Structural.Decorator
{
    public abstract  class LibraryItem
    {
        private int _numCopies;

        // Property

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }
}
