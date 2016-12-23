using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Diagnostics.PerformanceCounters;

namespace Sitecore.Support.Diagnostics.PerformanceCounters
{
    class AmountPerSecondCounterCollection : System.Collections.ObjectModel.Collection<AmountPerSecondCounter>
    {
        public AmountPerSecondCounter[] ToArray()
        {
            AmountPerSecondCounter[] array = new AmountPerSecondCounter[base.Count];
            for (int i = 0; i < base.Count; i++)
            {
                array[i] = base[i];
            }
            return array;
        }

    }
}