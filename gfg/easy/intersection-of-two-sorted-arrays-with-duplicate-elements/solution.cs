class Solution {
    public List<int> intersection(int[] a, int[] b) {
        // code here
        List<int> result = new List<int>();
        int i=0;
        int j=0;
        while(i<a.Length && j<b.Length)
        {
            if(a[i]==b[j] && !result.Contains(a[i]))
            {
                result.Add(a[i]);
                i++;
                j++;
            }
            else
            {
                if(a[i]<b[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
        }
        return result;
    }
}