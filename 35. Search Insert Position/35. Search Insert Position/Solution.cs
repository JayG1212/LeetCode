// Written by Jay Gunderson
// 11/16/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._Search_Insert_Position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Count()-1;
            
            while(left <= right)
            {
                int midpoint = (left + right) / 2;
                if (nums[midpoint] < target)
                {
                    left = midpoint + 1;
                }
                else if (nums[midpoint] > target)
                {
                    right = midpoint - 1;
                }
                else
                {
                    return midpoint;
                }
            }

            return left;      
        }
    }
}
