public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new();

        if (nums.Length == 0) return result;
        if (nums.Length == 1) {
            result.Add(nums[0].ToString());
            return result;
        }

        int start = nums[0];
        int end = nums[0];
        for (int i = 0; i < nums.Length; i++) {
            if (end != nums[i]) {
                if (start != end - 1) {
                    result.Add($"{start}->{end - 1}");
                } else result.Add(start.ToString());

                start = nums[i];
                end = nums[i];
            }

            end++;
        }

        if (start != end - 1) {
            result.Add($"{start}->{end - 1}");
        } else result.Add(start.ToString());

        return result;
    }
}