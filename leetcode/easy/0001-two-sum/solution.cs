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