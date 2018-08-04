﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Creational.AbstractFactory
{
    class AfricaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
