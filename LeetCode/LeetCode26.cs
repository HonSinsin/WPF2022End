using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode26
    {
        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> visited = new HashSet<int>();
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                visited.Add(nums[i]);
            }
            i = 0;
            foreach (var item in visited)
            {
                nums[i++] = item;
            }

            return visited.Count;
        }
    }
}
