using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Mediator
{
    abstract class Colleague
    {
        protected Mediator mediator;

        // Constructor

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
