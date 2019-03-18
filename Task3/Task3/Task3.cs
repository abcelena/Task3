using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3
    {
        public int solution(int[] A, int M)
        {
            var subsetSizes = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                var subset = new int[0];
                subsetSizes.Add(GetMAllignedSubsetSize(A, M, i, subset));
            }

            return subsetSizes.Max(x => x);
        }

        private int GetMAllignedSubsetSize(int[] A, int M, int index, int[] subset)
        {
            while (true)
            {
                var subsetSize = subset.Length;
                if (index >= A.Length)
                {
                    return subsetSize;
                }

                if (subsetSize == 0)
                {
                    Array.Resize(ref subset, 1);
                    subset[0] = A[index];
                    index += 1;
                    continue;
                }

                if (subset.Any(x => Math.Abs(A[index] - x) % M != 0))
                {
                    index += 1;
                    continue;
                }

                int newSize = subset.Length + 1;
                Array.Resize(ref subset, newSize);
                subset[newSize - 1] = A[index];
                index = index + 1;
            }
        }
    }
}
