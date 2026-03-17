public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> sMap = new();
        Dictionary<char, char> tMap = new();

        for (int i = 0; i < s.Length; i++) {
            if (!sMap.ContainsKey(t[i])) sMap[t[i]] = s[i];
            else if (sMap[t[i]] != s[i]) return false;

            if (!tMap.ContainsKey(s[i])) tMap[s[i]] = t[i];
            else if (tMap[s[i]] != t[i]) return false;
        }

        return true;
    }
}