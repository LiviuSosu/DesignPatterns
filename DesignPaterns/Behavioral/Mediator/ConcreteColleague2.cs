using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Mediator
{
    class ConcreteColleague2 : Colleague
    {
        // Constructor
        public ConcreteColleague2(Mediator mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: "

              + message);
        }
    }
}
