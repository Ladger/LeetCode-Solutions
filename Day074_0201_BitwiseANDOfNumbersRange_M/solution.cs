public class Solution {
    public int SingleNumber(int[] nums) {
        int ones = 0;
        int twos = 0;

        for (int i = 0; i < nums.Length; i++) {
            twos |= ones & nums[i];
            ones ^= nums[i];

            int common = ones & twos;

            ones &= ~common;
            twos &= ~common;
        }

        return ones;
    }
}