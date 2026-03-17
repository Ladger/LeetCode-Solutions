public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int k = nums.Length - 1;
        for (int i = 0; i <= k; i++) {
            if (nums[i] == val) {
                while (nums[i] == val) {
                    nums[i] = nums[k];
                    nums[k] = -1;
                    k--;
                }
            } 
        }

        return k + 1;
    }
}