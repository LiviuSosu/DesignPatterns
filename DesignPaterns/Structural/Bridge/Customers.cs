﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Structural.Bridge
{
    class Customers : CustomersBase
    {
        public Customers(string group)
     : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
