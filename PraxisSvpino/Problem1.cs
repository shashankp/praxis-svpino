using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisSvpino
{
    public static class Problem1
    {
        public static int Sum_For(List<int> l)
        {
            var sum = 0;
            foreach (var i in l)
            {
                sum += i;
            }
            return sum;
        }

        public static int Sum_While(List<int> l)
        {
            int sum = 0, i = 0;
            while (i < l.Count())
            {
                sum += l[i];
                i++;
            }
            return sum;
        }

        public static int Sum_Recursive(List<int> l)
        {
            Func<List<int>, int> sum = null;
            sum = (x) =>
            {
                if (!x.Any()) return 0;

                var first = x[0];
                x.RemoveAt(0);

                return first + sum(x);
            };

            var lcopy = new List<int>();
            l.ForEach(lcopy.Add);

            return sum(lcopy);
        }

        public static int Sum_Linq(List<int> l)
        {
            return l.Sum();
        }

        /*
        * https://blog.svpino.com/2015/05/07/five-programming-problems-every-software-engineer-should-be-able-to-solve-in-less-than-1-hour
        */
        static void Main(string[] args)
        {
        }
    }
}
