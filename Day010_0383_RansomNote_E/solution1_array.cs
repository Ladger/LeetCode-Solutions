public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;

        int[] count = new int[26];
        foreach (var c in magazine) {
            count[c - 'a']++;
        }

        foreach (var c in ransomNote) {
            count[c - 'a']--;
            if (count[c - 'a'] < 0) return false;
        }

        return true;
    }
}