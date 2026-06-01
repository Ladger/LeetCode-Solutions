public class Solution {
    public string LongestPalindrome(string s) {
        int maxLen = 1;
        int start = 0;

        bool[,] dp = new bool[s.Length, s.Length];
        for (int len = 1; len <= s.Length; len++) {
            for (int i = 0; i + len - 1 < s.Length; i++) {
                int j = i + len - 1;

                if (len == 1) {
                    dp[i, j] = true;
                }
                else if (len == 2) {
                    dp[i, j] = (s[i] == s[j]);
                }
                else {
                    dp[i, j] = (s[i] == s[j]) && dp[i+1, j-1];
                }

                if (dp[i, j] && len > maxLen) {
                    start = i;
                    maxLen = len;
                }
            }
        }

        return s.Substring(start, maxLen);
    }
}