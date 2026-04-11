public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longest = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            StringBuilder sb = new("");
            for (int j = 0; j < longest.Length; j++) {
                if (j >= strs[i].Length || longest[j] != strs[i][j]) break;
                sb.Append(strs[i][j]); 
            }

            longest = sb.ToString();
        }

        return longest;
    }
}