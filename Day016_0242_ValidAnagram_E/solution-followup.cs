public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict = new();

        for (int i = 0; i < s.Length; i++) {
            dict[s[i]] = dict.GetValueOrDefault(s[i]) + 1;
            dict[t[i]] = dict.GetValueOrDefault(t[i]) - 1;
        }

        foreach (var v in dict.Values) {
            if (v != 0) return false;
        }

        return true;
    }
}