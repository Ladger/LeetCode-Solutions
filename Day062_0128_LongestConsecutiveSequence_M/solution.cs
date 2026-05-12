public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        
        for (int i = 0; i < dp.Length; i++) {
            dp[i] = 1;
        }

        int length = 1;
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i - 1; j >= 0; j--) {
                if (nums[i] > nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    length = Math.Max(length, dp[i]);
                }
            }
        }

        return length;
    }
}