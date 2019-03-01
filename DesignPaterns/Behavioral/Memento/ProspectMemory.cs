using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Memento
{
    class ProspectMemory
    {
        private Memento _memento;

        // Property

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
