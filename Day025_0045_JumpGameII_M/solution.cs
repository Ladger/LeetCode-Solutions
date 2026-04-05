public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1) return 0;

        int counter = 0;
        int i = 0;
        while (i < nums.Length - 1) {
            counter++;

            if (nums[i] + i >= nums.Length - 1) break;
            
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

        return counter;
    }
}