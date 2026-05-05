public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if (n == 1) return nums[0];

        int[] mem = new int[n];

        mem[0] = nums[0];
        mem[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < n; i++) {
            mem[i] = Math.Max(mem[i - 2] + nums[i], mem[i - 1]);
        }

        return mem[n - 1];
    }
}