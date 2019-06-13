using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    interface ICard
    {
        decimal GetDiscountRate();
        decimal GetDiscount();
        decimal GetTotal();
    }
}
