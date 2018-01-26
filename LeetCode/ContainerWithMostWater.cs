using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var l = 0;
            var r = height.Length - 1;
            var max = -1;
            while (l < r)
            {
                var result = Math.Min(height[l], height[r]) * (r - l);
                if (result > max)
                {
                    max = result;
                }

                if (height[r] > height[l])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return max;
        }
    }
}
