class Solution {
    public List<int> findUnion(int[] a, int[] b) {
        // code here
        int n1=a.Length;
        int n2=b.Length;
        int i=0;
        int j=0;
        List<int> c=new List<int>();
        while(i<n1 && j<n2)
        {
            if(a[i]<=b[j])
            {
                c.Add(a[i]);
                i++;
            }
            else
            {
                c.Add(b[j]);
                j++;
            }
            while(i<n1 && a[i]==c[c.Count-1])
            {
               
                    i++;
                
            }
            while(j<n2 && b[j]==c[c.Count-1])
            {
                j++;
            }
        }
        if(i<n1)
        {
          int m=i;
            while(m<n1){
                c.Add(a[m]);
                while(m<n1 && a[m]==c[c.Count-1])
                {
                    m++;
                }
            }
            m=i;
            
        }
        if(j<n2)
        {
            int m=j;
            while(m<n2)
            {
                c.Add(b[m]);
                while(m<n2 && b[m]==c[c.Count-1])
                {
                    m++;
                }
            }
            m=j;
            
        }
        return c;
    }
}
