using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Behavioral.Observer
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
