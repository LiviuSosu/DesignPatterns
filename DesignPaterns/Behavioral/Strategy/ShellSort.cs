using System;
using System.Collections.Generic;

namespace DesignPaterns.Behavioral.Strategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }
}
