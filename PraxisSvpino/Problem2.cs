using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisSvpino
{
    public static class Problem2
    {
        public static List<string> Combine(List<string> l1, List<string> l2)
        {
            var combined = new List<string>();
            var minIndex = Math.Min(l1.Count(), l2.Count());
            for (var i = 0; i < minIndex; i++)
            {
                combined.Add(l1[i]);
                combined.Add(l2[i]);
            }

            return combined;
        }
    }
}
