public class Solution {
    public string ReverseWords(string s) {
        Stack<string> st = new();

        int i = 0;
        while (i < s.Length) {
            while (i != s.Length && s[i] == ' ') {
                i++;
            }

            var sb = new StringBuilder();
            while (i != s.Length && s[i] != ' ') {
                sb.Append(s[i]);
                i++;
            }

            if (sb.Length > 0) st.Push(sb.ToString());
        }

        var result = new StringBuilder();
        while (st.Count() != 0) {
            result.Append(st.Pop());

            if (st.Count() != 0) result.Append(' ');
        }

        return result.ToString();
    }
}