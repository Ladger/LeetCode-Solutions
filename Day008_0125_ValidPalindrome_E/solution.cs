public class Solution {
    public bool IsPalindrome(string s) {
        
        int l = 0;
        int r = s.Length - 1;

        s = s.ToLower();

        while (l < r) {
            bool validL = char.IsLetterOrDigit(s[l]);
            bool validR = char.IsLetterOrDigit(s[r]);

            if (!validL) {
                l++;
                continue;
            }

            if (!validR) {
                r--;
                continue;
            }

            if (s[l] != s[r]) return false;

            l++;
            r--;
        }

        return true;
    }
}