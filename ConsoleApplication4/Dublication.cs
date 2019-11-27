using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTask
{
    class Dublication
    {
        public List<int> Dublicates(List<int> n)
        {
            n.Sort();
            for (int i = 1; i < n.Count; i++)
                if (n[i] == n[i - 1])
                {
                    var elem = n[i];
                    n.RemoveAt(i);
                    n.RemoveAt(i - 1);
                    n.Add(elem);
                }
            return n;
        }

        public IEnumerable<int> DublicatesWithLinq(List<int> ar)
        {
            return ar.OrderBy(i => ar.Count(r => i == r) > 1 ? 1 : 0).Distinct();
        }
    }
}
