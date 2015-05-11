using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisSvpino
{
    public static class Problem4
    {
        public static string LargestNumber(List<uint> l)
        {
            var s = l.Select(x => Convert.ToString(x)).ToList();
            s.Sort(new MyComparer());
            return String.Join("", s);
        }
    }

    internal class MyComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return -1 * String.Compare(x + y, y + x, StringComparison.Ordinal);
        }
    }
}
