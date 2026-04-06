public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1) return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new();
        result.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++) {
            int[] last = result[result.Count - 1];
            int[] current = intervals[i];

            if (current[0] <= last[1]) {
                last[1] = Math.Max(last[1], current[1]);
            } else {
                result.Add(current);
            }
        }

        return result.ToArray();
    }
}