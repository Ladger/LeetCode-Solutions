public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums.Length == 0) return;

        int shiftAmount = k % nums.Length;
        if (shiftAmount == 0) return;

        int[] shiftedNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            int shiftedIndex = (i + shiftAmount) % nums.Length;
            shiftedNums[shiftedIndex] = nums[i];
        }

        Array.Copy(shiftedNums, 0, nums, 0, nums.Length);
    }
}