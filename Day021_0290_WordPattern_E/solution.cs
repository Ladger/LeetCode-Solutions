public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        if (pattern.Length != words.Length) return false;

        Dictionary<char, string> ctos = new();
        Dictionary<string, char> stoc = new();
        
        for (int i = 0; i < pattern.Length; i++) {
            if (!ProcessWord(ctos, stoc, pattern[i], words[i])) return false;
        }

        return true;
    }

    public bool ProcessWord(Dictionary<char, string> ctos, Dictionary<string, char> stoc, char c, string s) 
    {
        bool hasC = ctos.TryGetValue(c, out string sVal);
        bool hasS = stoc.TryGetValue(s, out char cVal);

        if (hasC && hasS)
        {
            return c == cVal && s == sVal;
        }
        else if (!hasC && !hasS)
        {
            ctos[c] = s;
            stoc[s] = c;
            return true;
        }

        return false;
    }
}