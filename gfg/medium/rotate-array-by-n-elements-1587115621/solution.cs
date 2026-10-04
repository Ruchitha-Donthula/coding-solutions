class Solution {
    public void rotateArr(int[] arr, int d) {
        // code here
        if(d>arr.Length)
        {
            d=d%arr.Length;
        }
        
        int[] temp=new int[arr.Length];
        for(int i=0;i<d;i++)
        {
            temp[i]=arr[i];
        }
        for(int i=d;i<arr.Length;i++)
        {
            arr[i-d]=arr[i];
        }
        //int j=0;
        //for(int i=arr.Length-d;i<arr.Length;i++)
        //{
         //   arr[i]=temp[j];
         //   j++;
        //}
        //originalIndexIntemp +(n-d)=i
        //i-(n-d)=x
        //0=3-(5-3)
        for(int i=arr.Length-d;i<arr.Length;i++)
        {
            arr[i]=temp[i-(arr.Length-d)];
        }
    }
}