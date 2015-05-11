using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraxisSvpino
{
    public static class Problem5
    {
        public static List<string> GetCombinationsSummingTo100()
        {
            return GetC(100, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        private static List<string> GetC(int t, List<int> l)
        {
            var op = new List<string>();
            if (!l.Any())
            {
                return op;
            }
            else if (l.Count() == 1 && l.First() == t)
            {
                op.Add(Convert.ToString(l.First()));
            }
            else if (l.Count() == 2)
            {
                if (t == l[0] + l[1]) op.Add(String.Format("{0}+{1}", l[0], l[1]));
                if (t == l[0] - l[1]) op.Add(String.Format("{0}-{1}", l[0], l[1]));
                if (t == l[0] * 10 + l[1]) op.Add(String.Format("{0}{1}", l[0], l[1]));
            }
            else
            {
                var ladd = GetC(t - l[0], l.Skip(1).ToList()).Select(x => String.Format("{0}+{1}", l[0], x)).ToList();
                if (ladd.Any()) op.AddRange(ladd);

                var lc = l.Skip(1).ToList();
                lc[0] *= -1;
                var lsub = GetC(t - l[0], lc).Select(x => l[0].ToString(CultureInfo.InvariantCulture) + x).ToList();
                if (lsub.Any()) op.AddRange(lsub);

                lc = l.Skip(2).ToList();
                lc.Insert(0, l[0] * 10 + l[1]);
                var lconcat = GetC(t, lc).ToList();
                if (lconcat.Any()) op.AddRange(lconcat);

            }

            return op;
        }
    }
}
