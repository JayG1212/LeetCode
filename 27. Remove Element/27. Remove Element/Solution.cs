using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;

            for(int j = 0; j< nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
