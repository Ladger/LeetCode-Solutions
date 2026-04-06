public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 1) return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = intervals.ToList();
        for (int i = 1; i < result.Count; i++) {
            if (result[i][0] <= result[i - 1][1]) {
                int f = result[i - 1][1] > result[i][1] ? result[i - 1][1] : result[i][1];
                result[i - 1] = new int[] {result[i-1][0], f};
                result.RemoveAt(i);
                i--;
            }
        }

        return result.ToArray();
    }
}