using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    public class PurchaseCalculation
    {
        public object Execute(int qty, decimal amount, bool withVAT)
        {
            if (withVAT)
            {
                return qty * amount * 1.25M;
            } else
            {
                return qty * amount;
            }
        }
    }
}
