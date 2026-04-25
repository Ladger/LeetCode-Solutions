public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int total = 0;
        int min = int.MaxValue;
        int l = 0;
        for (int r = 0; r < nums.Length; r++) {
            total += nums[r];

            while (total >= target) {
                min = Math.Min(min, r - l + 1);
                total -= nums[l];
                l++;
            }
        }

        return min < int.MaxValue ? min : 0;
    }
}