// Written by Jay Gunderson
// 11/16/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283._Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {

            for (int i = 0; i < nums.Count() - 1; i++)
            {
                for (int j = 0; j < nums.Count() - 1; j++)
                {
                    if (nums[j] == 0)
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
}
