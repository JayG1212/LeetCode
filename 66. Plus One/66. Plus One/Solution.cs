// Written by Jay Gunderson
// 11/16/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66._Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Count()-1; i >= 0; i--)
                {
                if (digits[i] + 1 != 10)
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
                digits[i] = 0;
                }
            int[] newDigits = new int[digits.Count() + 1];
            newDigits[0] = 1;
            return newDigits;

        }
    } 
}

