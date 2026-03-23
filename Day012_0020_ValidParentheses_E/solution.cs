public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0) return false;

            if (c == ')' && stack.Pop() != '(') return false;
            else if (c == '}' && stack.Pop() != '{') return false;
            else if (c == ']' && stack.Pop() != '[') return false;
        }

        return stack.Count == 0;
    }
}