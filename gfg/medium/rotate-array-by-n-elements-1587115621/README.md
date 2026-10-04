# Rotate Array

![Difficulty](https://img.shields.io/badge/Difficulty-Medium-yellow)

## Problem

Given an array  **arr[]**. Rotate the array to the left (counter-clockwise direction) by  **d**  steps, where  *d*  is a positive integer. Do the mentioned change in the array in place.

 **Note:** Consider the array as circular.

**Examples :
**

```
Input: arr[] = [1, 2, 3, 4, 5], d = 2
Output: [3, 4, 5, 1, 2]
Explanation: when rotated by 2 elements, it becomes [3, 4, 5, 1, 2].
```

```
Input: arr[] = [2, 4, 6, 8, 10, 12, 14, 16, 18, 20], d = 3
Output: [8, 10, 12, 14, 16, 18, 20, 2, 4, 6]
Explanation: when rotated by 3 elements, it becomes [8, 10, 12, 14, 16, 18, 20, 2, 4, 6].

```

```
Input: arr[] = [7, 3, 9, 1], d = 9
Output: [3, 9, 1, 7]
Explanation: when we rotate 9 times, we'll get [3, 9, 1, 7] as resultant array.
```

## Solution

**Language:** C#  
**Runtime:** N/A  
**Memory:** N/A  
**Submitted:** 2026-10-04T11:52:53.000Z  

```cs
class Solution {
    public void rotateArr(int[] arr, int d) {
        // code here
        if(d>arr.Length)
        {
            d=d%arr.Length;
        }
        
        int[] temp=new int[arr.Length];
        for(int i=0;i<d;i++)
        {
            temp[i]=arr[i];
        }
        for(int i=d;i<arr.Length;i++)
        {
            arr[i-d]=arr[i];
        }
        //int j=0;
        //for(int i=arr.Length-d;i<arr.Length;i++)
        //{
         //   arr[i]=temp[j];
         //   j++;
        //}
        //originalIndexIntemp +(n-d)=i
        //i-(n-d)=x
        //0=3-(5-3)
        for(int i=arr.Length-d;i<arr.Length;i++)
        {
            arr[i]=temp[i-(arr.Length-d)];
        }
    }
}
```

---

[View on GeeksforGeeks](https://practice.geeksforgeeks.org/problems/rotate-array-by-n-elements-1587115621/1)