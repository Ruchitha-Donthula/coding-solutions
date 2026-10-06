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