public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack.Length < needle.Length) return -1;

        int[] lps = ConstructLPS(needle);
        
        int i = 0;
        int j = 0;

        while (i < haystack.Length) {
            if (haystack[i] == needle[j]) {
                i++;
                j++;

                if (j == needle.Length) return i - j;
            }
            else {
                if (j != 0) j = lps[j - 1];
                else i++;
            }
        }

        return -1;
    }

    public int[] ConstructLPS(string needle) {
        int[] lps = new int[needle.Length];

        int len = 0;
        lps[0] = 0;

        int i = 1;

        while (i < needle.Length) {
            if (needle[i] == needle[len]) {
                len++;
                lps[i] = len;
                i++;
            }
            else {
                if (len == 0) {
                    lps[i] = 0;
                    i++;
                }
                else {
                    len = lps[len - 1];
                }
            }
        }

        return lps;
    }
}