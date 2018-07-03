using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class PayRate
    {
        public int payRateAdjuster(int weeklyAmount, int weeklyHours = 30)
        {
            return weeklyAmount / weeklyHours;
        }

    }
}
