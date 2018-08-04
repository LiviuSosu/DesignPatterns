using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Creational.AbstractFactory
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
