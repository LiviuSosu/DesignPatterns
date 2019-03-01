using System.Collections.Generic;

namespace DesignPaterns.Behavioral.Strategy
{
    abstract  class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
