using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode35
    {
        public int SearchInsert(int[] nums, int target)
        {
            nums = new int[] { 1, 3, 5, 6 };
            target = 2;
            int result = -1;

            // 存在数组内 即获取下表
            if (nums.Contains(target))
            {
                return Array.IndexOf(nums, target);
            }

            // 由于数组递增, 大于最后一个排在最后, 下标为数组的长度
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            // 由于数组递增, 小于第一个排在首位, 下标为0
            else if (target < nums[0])
            {
                return 0;
            }

            // 不在上述情况 查找查找下标, 当某元素大于给定值时插入该元素前
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    return i;
                }
            }

            return result;
        }
    }
}
