// Written by Jay Gunderson
// 08/28/2024
/*
My answer to Leetcode problem 26.Remove Duplicates from Sorted Array:
Which asks me to return the number of unique elements in an array and to organize the array, by putting the  first instance of each number at the start of the array
*/
public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
    
    int uniqueElements = 0; // Points to the unique element
    
    for(int index = 1; index < nums.Length; index++)
    {
        if(nums[uniqueElements] != nums[index]) // If we encounter a number that is not equal to the previous one
        {
            uniqueElements++; // We increment our total of unique elements
            nums[uniqueElements] = nums[index]; // And put the unique number near the front of the list, leaving the first instance of each number at the start of the list
        }
        
    }
    return uniqueElements +1;
    }
}

