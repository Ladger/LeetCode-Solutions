public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;

        int n = s.Length;
        int cycleLen = 2 * numRows - 2;
        var result = new StringBuilder();

        for (int row = 0; row < numRows; row++) {
            for (int i = row; i < n; i += cycleLen) {
                result.Append(s[i]);

                int second = i + cycleLen - 2 * row;
                if (row != 0 && row != numRows - 1 && second < n) {
                    result.Append(s[second]);
                }
            }
        }

        return result.ToString();
    }
}