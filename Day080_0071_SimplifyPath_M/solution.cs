public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> s = new();
        string[] tokens = path.Split('/');

        foreach (var t in tokens) {
            if (t == "" || t == ".") continue;
            if (t == "..") {
                if (s.Count != 0) s.Pop();
                continue;
            }

            s.Push(t);
        }

        List<string> result = new();
        foreach (var dir in s) {
            result.Add(dir);
        }

        string[] arr = result.ToArray();
        Array.Reverse(arr);
        string res = "/" + string.Join('/', arr);

        return res;
    }
}