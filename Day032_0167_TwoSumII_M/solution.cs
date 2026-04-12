public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;

        while (l < r) {
            int total = numbers[l] + numbers[r];
            if (total == target) return new int[] {l+1, r+1};

            if (total > target) r--;
            else l++;
        }

        return null;
    }
}