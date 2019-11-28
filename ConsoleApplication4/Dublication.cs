using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTask
{
    class Dublication
    {
        public int[] DublicatesMoveToEnd(int[] n)
        {
            int[] dublication = new int[n.Length];
            int m = n.Length - 1;
            int b = 0;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if ((n[i] == n[j]) && (n[i] != 0) && (n[j] != 0))
                    {
                        dublication[m] = n[i];
                        dublication[m - 1] = n[j];
                        m -= 2;
                        n[i] = 0;
                        n[j] = 0;
                    }
                }
                if (n[i] != 0)
                {
                    dublication[b] = n[i];
                    b++;
                }
            }
            return dublication;
        }
        public int[] JustOneDublicateMoveToEnd(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        int temp = nums[j];
                        int temp2 = nums[i];
                        for (int k = j; k < nums.Length - 1; k++)
                        {
                            nums[k] = nums[k + 1];
                        }
                        nums[nums.Length - 1] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
