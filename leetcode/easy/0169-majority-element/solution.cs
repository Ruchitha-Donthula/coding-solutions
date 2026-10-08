public class Solution {
    public int MajorityElement(int[] nums) {
        //Morre's voting algorithm
        //if it is said that if a number occurs more than n/2 times its the majority element
        //that mean if we cancel the non majority element then the highest will alwasys be there
            
            var majorityElement=nums[0];
            int count=1;
            for(int i=1;i<nums.Length;i++)
            {
                if(count==0)
                {
                    majorityElement=nums[i];
                }
                if(nums[i]==majorityElement)
                {
                            count++;
                }
                else
                {
                    count--;
                }
            }
                    
        return majorityElement;           
    }
        
}