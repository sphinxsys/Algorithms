using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDistance
{
    public class LevenshteinDistance
    {
        public static int Calculate(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
            {
                throw new NullReferenceException("Comparable strings NOT allow null");
            }

            if (string.IsNullOrWhiteSpace(a))
            {
                return b.Length;
            }

            if (string.IsNullOrWhiteSpace(b))
            {
                return a.Length;
            }

            if (a == b)
            {
                return 0;
            }

            var n = a.Length;
            var m = b.Length;

            var distanceMatrix = new int[n+1,m+1];

            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; j <= m; j++)
                {
                    if (j == 0)
                    {
                        distanceMatrix[i, j] = i;
                    }
                    else if (i == 0)
                    {
                        distanceMatrix[i, j] = j;
                    }
                    else
                    {
                        distanceMatrix[i,j] = Int32.MaxValue;
                    }
                }
            }

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= m; j++)
                {
                    var cost = a[i - 1] == b[j - 1] ? 0 : 1;

                    distanceMatrix[i, j] = Math.Min(Math.Min(distanceMatrix[i-1, j] + 1, distanceMatrix[i, j-1] + 1), distanceMatrix[i-1,j-1] + cost);
                }
            }

            return distanceMatrix[n,m];
        }
    }
}
