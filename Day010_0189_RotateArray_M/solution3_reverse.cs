public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        if (k == 0) return;

        Array.Reverse(nums, 0, n - k);
        Array.Reverse(nums, n - k, k);
        Array.Reverse(nums);
    }
}