using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Creational.AbstractFactory
{
    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
