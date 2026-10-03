# Remove Duplicates Sorted Array

![Difficulty](https://img.shields.io/badge/Difficulty-Easy-green)

## Problem

You are given a sorted array  **arr[]** containing positive integers. Your task is to remove all duplicate elements from this array such that each element appears only once. Return an array containing these distinct elements in the same order as they appeared.

 **Examples :** 

```
Input: arr[] = [2, 2, 2, 2, 2]
Output: [2]
Explanation: After removing all the duplicates only one instance of 2 will remain i.e. [2] so modified array will contains 2 at first position and you should return array containing [2] after modifying the array.

```

```
Input: arr[] = [1, 2, 4]
Output: [1, 2, 4]
Explanation:  As the array does not contain any duplicates so you should return [1, 2, 4].
```

## Solution

**Language:** C#  
**Runtime:** N/A  
**Memory:** N/A  
**Submitted:** 2026-10-03T07:43:42.368Z  

```cs
class Solution {
    public List<int> removeDuplicates(int[] arr) {
        // code here
        List<int> temp=new List<int>();
        int i=0;
        while(i<arr.Length)
        {
            temp.Add(arr[i]);
            int j=i+1;
            while(j<arr.Length && arr[j]==arr[i])
            {
                j++;
            }
            if(j>=arr.Length)
            {
                return temp;
            }
            else
            {
               i=j; 
            }
                
            
        }
        return temp;
    }
}
```

---

[View on GeeksforGeeks](https://practice.geeksforgeeks.org/problems/remove-duplicate-elements-from-sorted-array/1)