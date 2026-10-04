public class Solution {
    public void Rotate(int[] nums, int k) {
        // Brute Force
        int[] arr=new int[nums.Length];
        int j=0;
        for(int i=nums.Length-k;i<nums.Length;i++)
        {
            arr[j]=nums[i];
            j++;
        }
        for(int i=0; i<nums.Length-k;i++)
        {
            arr[j]=nums[i];
            j++;
        }
        for(int i=0;i<nums.Length;i++)
        {
            nums[i]=arr[i];
        }
        //best Approach
        
    }
}