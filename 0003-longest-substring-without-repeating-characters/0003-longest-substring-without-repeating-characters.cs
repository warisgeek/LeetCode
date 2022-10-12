public class Solution {
    public int LengthOfLongestSubstring(string s) {
         int n = s.Length;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            
               bool[] visited = new bool[256];
         
        for(int j = i; j < n; j++)
        {
            if (visited[s[j]] == true)
                break;
 
            else
            {
                res = Math.Max(res, j - i + 1);
                visited[s[j]] = true;
            }
        }
        visited[s[i]] = false;
            
        }
        return res;
    }
}