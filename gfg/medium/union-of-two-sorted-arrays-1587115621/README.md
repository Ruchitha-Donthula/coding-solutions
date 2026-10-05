# Union of 2 Sorted Arrays

![Difficulty](https://img.shields.io/badge/Difficulty-Medium-yellow)

## Problem

Given two sorted arrays  **a[]**  and  **b[]**, where each array may contain duplicate elements, the task is to return the elements in the union of the two arrays in sorted order. Union of two arrays can be defined as the set containing distinct elements that are present in either of the arrays.

 **Examples:** 

```
Input: a[] = [1, 2, 3, 4, 5], b[] = [1, 2, 3, 6, 7]
Output: [1, 2, 3, 4, 5, 6, 7]
Explanation: Distinct elements including both the arrays are: 1 2 3 4 5 6 7.
```

```
Input: a[] = [2, 2, 3, 4, 5], b[] = [1, 1, 2, 3, 4]
Output: [1, 2, 3, 4, 5]
Explanation: Distinct elements including both the arrays are: 1 2 3 4 5.
```

```
Input: a[] = [1, 1, 1, 1, 1], b[] = [2, 2, 2, 2, 2]
Output: [1, 2]
Explanation: Distinct elements including both the arrays are: 1 2.
```

## Solution

**Language:** C#  
**Runtime:** N/A  
**Memory:** N/A  
**Submitted:** 2026-10-05T14:43:19.057Z  

```cs
class Solution {
    public List<int> findUnion(int[] a, int[] b) {
        // code here
        int n1=a.Length;
        int n2=b.Length;
        int i=0;
        int j=0;
        List<int> c=new List<int>();
        while(i<n1 && j<n2)
        {
            if(a[i]<=b[j])
            {
                c.Add(a[i]);
                i++;
            }
            else
            {
                c.Add(b[j]);
                j++;
            }
            while(i<n1 && a[i]==c[c.Count-1])
            {
               
                    i++;
                
            }
            while(j<n2 && b[j]==c[c.Count-1])
            {
                j++;
            }
        }
        if(i<n1)
        {
          int m=i;
            while(m<n1){
                c.Add(a[m]);
                while(m<n1 && a[m]==c[c.Count-1])
                {
                    m++;
                }
            }
            m=i;
            
        }
        if(j<n2)
        {
            int m=j;
            while(m<n2)
            {
                c.Add(b[m]);
                while(m<n2 && b[m]==c[c.Count-1])
                {
                    m++;
                }
            }
            m=j;
            
        }
        return c;
    }
}

```

---

[View on GeeksforGeeks](https://practice.geeksforgeeks.org/problems/union-of-two-sorted-arrays-1587115621/1)