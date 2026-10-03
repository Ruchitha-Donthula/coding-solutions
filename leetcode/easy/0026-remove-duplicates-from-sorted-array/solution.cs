public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i=0;
        int j=1;
        int count=1;
        while(j<nums.Length)
        {
            if(nums[j]==nums[i])
            {
                j++;
            }
            else
            {
                count++;
                i++;
                nums[i]=nums[j];
                j++;
            }
        }
        return count;
    }
}