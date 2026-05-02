public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> result = new();

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i != 0 && nums[i] == nums[i - 1]) continue;
            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {
                int sum = nums[l] + nums[r] + nums[i];
                if (sum < 0) {
                    l++;
                }
                else if (sum > 0) {
                    r--;
                }
                else {
                    result.Add(new List<int> {nums[i], nums[l], nums[r]});
                    do {l++;} while(l < r && nums[l] == nums[l - 1]);
                    do {r--;} while(l < r && nums[r] == nums[r + 1]);
                }
            }
        }

        return result;
    }
}