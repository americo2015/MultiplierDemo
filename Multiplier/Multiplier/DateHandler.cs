using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    public class DateHandler
    {
        public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
        {
            return (secondDate - firstDate).Days;
        }

        public DateTime Add1000Days(DateTime theDate)
        {
            DateTime plus1000Days = theDate.AddDays(1000);

            return plus1000Days;
        }
    }
}
