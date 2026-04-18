public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int m = nums.Length / 2;
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r) {
            if (nums[m] < target) {
                l = m + 1;
            }
            else if (nums[m] > target) {
                r = m - 1;
            }
            else {
                return m;
            }

            m = l + (r - l) / 2;
        }

        return m;
    }
}