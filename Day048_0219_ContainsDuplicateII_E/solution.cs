public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> lookup = new();

        for (int i = 0; i < nums.Length; i++) {
            if (lookup.TryGetValue(nums[i], out int maxIndex)) {
                if (i - maxIndex <= k) return true;

                lookup[nums[i]] = i;
            }
            else {
                lookup[nums[i]] = i;
            }
        }

        return false;
    }
}