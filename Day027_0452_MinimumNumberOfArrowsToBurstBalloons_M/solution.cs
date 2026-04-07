public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a,b) => a[0].CompareTo(b[0]));
        
        int shots = 1;
        int[] narrowInterval = points[0];

        for (int i = 1; i < points.Length; i++) {
            int[] current = points[i];

            if (current[0] <= narrowInterval[1]) {
                narrowInterval[1] = Math.Min(current[1], narrowInterval[1]);
            }
            else {
                shots++;
                narrowInterval = current;
            }
        }

        return shots;
    }
}