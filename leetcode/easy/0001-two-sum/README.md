# Two Sum

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Problem

You are given an array of integers `nums` and an integer `target`, return  *indices of the two numbers such that they add up to `target`*.

You may assume that each input would have  ***exactly *one solution**, and you may not use the* same* element twice.

You can return the answer in any order.

 

 **Example 1:** 

```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

```

 **Example 2:** 

```
Input: nums = [3,2,4], target = 6
Output: [1,2]

```

 **Example 3:** 

```
Input: nums = [3,3], target = 6
Output: [0,1]

```

 

 **Constraints:** 

- 2 <= nums.length <= 104
- -109 <= nums[i] <= 109
- -109 <= target <= 109
- Only one valid answer exists.

 

 **Follow-up:** Can you come up with an algorithm that is less than `O(n2)` time complexity?

## Solution

**Language:** C#  
**Runtime:** 5 ms (beats 55.47%)  
**Memory:** 50 MB (beats 31.16%)  
**Submitted:** 2026-10-07T06:28:02.225Z  

```cs
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> temp=new Dictionary<int,int>();
       int[] result= new int[2];
       for(int i=0;i<nums.Length;i++)
       {
        if(temp.ContainsKey(target-nums[i]))
        {
            result[0]=i;
            result[1]=temp[target-nums[i]];
            return result;
        }
        else if(!temp.ContainsKey(nums[i]))
        {
            temp.Add(nums[i],i);
        }
       }
       return result;
    }
    public int[] BruteForce(int[] nums, int target)
    {
        int[] result= new int[2];
       for(int i=0;i<nums.Length;i++)
       {
        for(int j=i+1;j<nums.Length;j++)
        {
            if(i==j)
            {
                continue;
            }
            if(nums[i]+nums[j]==target)
            {
                result[0]=i;
                result[1]=j;
                return result;
            }
        }
       }
      return result; 
    }
}
```

---

[View on LeetCode](https://leetcode.com/problems/two-sum/)