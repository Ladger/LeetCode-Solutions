public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        int[] dp = new int[amount + 1];
        dp[0] = 0; 
        for (int i = 1; i <= amount; i++) {
            dp[i] = int.MaxValue;
            for (int j = 0; j < coins.Length; j++) {
                if (coins[j] <= i) {
                    if (dp[i - coins[j]] != int.MaxValue) {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
        }

        return dp[amount] != int.MaxValue ? dp[amount] : -1;
    }
}