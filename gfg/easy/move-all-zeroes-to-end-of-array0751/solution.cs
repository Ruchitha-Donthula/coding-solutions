class Solution {
    public void pushZerosToEnd(int[] arr) {
        // code here
        for(int i=0;i<arr.Length;i++)
                {

                    if(arr[i]==0)
                    {
                        int j=i+1;
                        while(j<arr.Length)
                        {
                            if(arr[j]!=0)
                            {
                                var temp=arr[i];
                                arr[i]=arr[j];
                                arr[j]=temp;
                                
                                break;
                            }
                            j++;
                            if(j>=arr.Length)
                            {
                                return;
                            }
                        }
                    }
                }
        
    }
}
