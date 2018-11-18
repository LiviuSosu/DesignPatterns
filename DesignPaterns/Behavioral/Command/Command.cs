using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
