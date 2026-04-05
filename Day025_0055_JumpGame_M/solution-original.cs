public class Solution {
    public bool CanJump(int[] nums) {
        int i = 0;
        while (i < nums.Length - 1) {
            if (nums[i] == 0) return false;
            if (nums[i] + i >= nums.Length - 1) return true;
            
            int nextIndex = -1;
            int maxReach = -1;

            for (int j = 1; j <= nums[i]; j++) {
                int reach = i + j + nums[i + j];
                if (reach > maxReach) {
                    nextIndex = i + j;
                    maxReach = reach;
                }
            }
            
            i = nextIndex;
        }

        return true;
    }
}