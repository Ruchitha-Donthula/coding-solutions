# Majority Element

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Problem

Given an array `nums` of size `n`, return  *the majority element*.

The majority element is the element that appears more than `⌊n / 2⌋` times. You may assume that the majority element always exists in the array.

 

 **Example 1:** 

```
Input: nums = [3,2,3]
Output: 3

```

 **Example 2:** 

```
Input: nums = [2,2,1,1,1,2,2]
Output: 2

```

 

 **Constraints:** 

- n == nums.length
- 1 <= n <= 5 * 104
- -109 <= nums[i] <= 109
- The input is generated such that a majority element will exist in the array.

 

 **Follow-up:**  Could you solve the problem in linear time and in `O(1)` space?

## Solution

**Language:** C#  
**Runtime:** 0 ms (beats 100.00%)  
**Memory:** 47.3 MB (beats 55.29%)  
**Submitted:** 2026-10-08T15:24:32.720Z  

```cs
public class Solution {
    public int MajorityElement(int[] nums) {
        //Morre's voting algorithm
        //if it is said that if a number occurs more than n/2 times its the majority element
        //that mean if we cancel the non majority element then the highest will alwasys be there
            
            var majorityElement=nums[0];
            int count=1;
            for(int i=1;i<nums.Length;i++)
            {
                if(count==0)
                {
                    majorityElement=nums[i];
                }
                if(nums[i]==majorityElement)
                {
                            count++;
                }
                else
                {
                    count--;
                }
            }
                    
        return majorityElement;           
    }
        
}
```

---

[View on LeetCode](https://leetcode.com/problems/majority-element/)