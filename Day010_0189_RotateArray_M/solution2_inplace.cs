public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        if (k == 0) return;

        int count = 0;
        for (int start = 0; count < nums.Length; start++) {
            int curr = nums[start];
            int currIndex = start;

            do {
                int nextIndex = (currIndex + k) % nums.Length;

                int temp = nums[nextIndex];
                nums[nextIndex] = curr;

                curr = temp;
                currIndex = nextIndex;

                count++;
            } while (start != currIndex);
        }
    }
}