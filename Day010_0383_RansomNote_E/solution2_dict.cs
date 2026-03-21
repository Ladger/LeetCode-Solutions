public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;

        Dictionary<char, int> magazineDict = new();
        for (int i = 0; i < magazine.Length; i++) {
            if (!magazineDict.ContainsKey(magazine[i])) magazineDict[magazine[i]] = 1;
            else magazineDict[magazine[i]]++;
        }

        for (int i = 0; i < ransomNote.Length; i++) {
            if (!magazineDict.ContainsKey(ransomNote[i])) return false;

            magazineDict[ransomNote[i]]--;
            if (magazineDict[ransomNote[i]] == 0) magazineDict.Remove(ransomNote[i]);
        }

        return true;
    }
}