public class Solution {
    public int MissingNumber(int[] nums) {
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum=sum+nums[i];
        }
        int actualSum=(nums.Length*(nums.Length+1))/2;
        return actualSum-sum;
    }
}