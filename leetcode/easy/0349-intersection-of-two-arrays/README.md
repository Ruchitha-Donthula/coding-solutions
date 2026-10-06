# Intersection of Two Arrays

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Problem

Given two integer arrays `nums1` and `nums2`, return  *an array of their intersection*. Each element in the result must be  **unique**  and you may return the result in  **any order**.

 

 **Example 1:** 

```
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]

```

 **Example 2:** 

```
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.

```

 

 **Constraints:** 

- 1 <= nums1.length, nums2.length <= 1000
- 0 <= nums1[i], nums2[i] <= 1000

## Solution

**Language:** C#  
**Runtime:** 14 ms (beats 5.44%)  
**Memory:** 48.2 MB (beats 5.88%)  
**Submitted:** 2026-10-06T13:50:03.932Z  

```cs
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        int n1=nums1.Length;
        int n2=nums2.Length;

            int[] temp= new int[n2];
            HashSet<int> result= new HashSet<int>();
      
        for(int i=0;i<n1;i++)
        {
            for(int j=0;j<n2;j++)
            {
                if(nums1[i]==nums2[j] && temp[j]!=1)
                {
                    result.Add(nums1[i]);
                    temp[j]=1;;
                }
                // else if(nums1[i]<nums2[j])
                // {
                //     break;
                // }
            }
        }
        int[] result1= result.ToArray();
        return result1;
    }
}
```

---

[View on LeetCode](https://leetcode.com/problems/intersection-of-two-arrays/)