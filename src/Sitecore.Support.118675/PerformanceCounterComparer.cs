using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    internal class PerformanceCounterComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            AmountPerSecondCounter counter = x as AmountPerSecondCounter;
            AmountPerSecondCounter counter2 = y as AmountPerSecondCounter;
            int num = counter.Category.CompareTo(counter2.Category);
            if (num != 0)
            {
                return num;
            }
            return counter.Name.CompareTo(counter2.Name);
        }
    }
}
