public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        List<int[]> l = intervals.ToList();
        l.Add(newInterval);
        l.Sort((a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new();
        result.Add(l[0]);

        for (int i = 1; i < l.Count; i++) {
            int[] last = result[result.Count - 1];
            int[] current = l[i];

            if (current[0] <= last[1]) {
                last[1] = Math.Max(last[1], current[1]);
            } else {
                result.Add(current);
            }
        }

        return result.ToArray();
    }
}