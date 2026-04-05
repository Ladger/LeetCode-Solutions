public class Solution {
    public int MaxProfit(int[] prices) {
        int min = 0;
        int max = 0;

        int profit = 0;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[min] > prices[i]) {
                min = i;
                max = i;
            }

            if (prices[max] < prices[i]) {
                max = i;
            }

            if (profit < prices[max] - prices[min]) profit = prices[max] - prices[min];
        }

        return profit;
    }
}