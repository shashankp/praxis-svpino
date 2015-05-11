using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisSvpino
{
    public static class Problem3
    {
        public static List<ulong> Fibonacci(uint c)
        {
            var f = new List<ulong> { 0, 1 };

            while (f.Count() < c)
            {
                f.Add(f[f.Count() - 1] + f[f.Count() - 2]);
            }
            return f;
        }
    }
}
