using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Structural.Flyweight
{
    public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public abstract void Display(int pointSize);
    }
}
