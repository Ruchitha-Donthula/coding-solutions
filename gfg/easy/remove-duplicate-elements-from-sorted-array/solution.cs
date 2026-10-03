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