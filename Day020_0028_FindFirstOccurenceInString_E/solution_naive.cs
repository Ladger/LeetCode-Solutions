public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack.Length < needle.Length) return -1;

        int cursor = 0;
        for (int i = 0; i < haystack.Length; i++) {
            cursor = i;
            if (haystack[i] == needle[0]) {
                bool isValid = true;
                foreach (var c in needle) {                    
                    if (cursor >= haystack.Length || c != haystack[cursor]) {
                        isValid = false;
                        break;
                    }

                    cursor++;
                    
                }

                if (isValid) return i;
            }
        }

        return -1;
    }
}