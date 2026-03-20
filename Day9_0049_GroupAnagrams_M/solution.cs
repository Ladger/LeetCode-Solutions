public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> lookup = new();

        foreach (var str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!lookup.TryGetValue(key, out var list)) {
                list = new List<string>();
                lookup[key] = list;
            }
            list.Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();
        foreach (var group in lookup.Values) {
            result.Add(group);
        }

        return result;
    }
}