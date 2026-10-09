public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] result= new int[nums.Length];
        int nextPositiveIndex=0;
        int nextNegativeIndex=1;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]>=0)
            {
                result[nextPositiveIndex]=nums[i];
                nextPositiveIndex+=2;
            }
            else
            {
                result[nextNegativeIndex]=nums[i];
                nextNegativeIndex+=2;
            }
        }
        return result;
    }
}