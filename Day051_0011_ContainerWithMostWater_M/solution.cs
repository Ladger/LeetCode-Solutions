public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int maxArea = 0;

        int l = 0;
        int r = n - 1;
        while (l < r) {
            int container = Math.Min(height[l], height[r]) * (r - l);
            maxArea = Math.Max(maxArea, container);

            if (height[l] < height[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return maxArea;
    }
}