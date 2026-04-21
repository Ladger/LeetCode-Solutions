public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        
        string s = x.ToString();

        for (int i = 0; i < s.Length / 2; i++) {
            if (s[i] != s[s.Length - i - 1]) return false;
        }

        return true;
    }
}