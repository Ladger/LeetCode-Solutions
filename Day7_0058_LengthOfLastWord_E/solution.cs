public class Solution {
    public int LengthOfLastWord(string s) {
        
        int bookmark = 0;
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') {
                bookmark = i;
                break;
            }
        }

        int length = 0;
        for (int i = bookmark; i >= 0; i--) {
            if (s[i] == ' ') break;
            length++;
        }

        return length;
    }
}