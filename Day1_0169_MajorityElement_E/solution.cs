public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> numDict = new();

        for (int i = 0; i < nums.Length; i++) {
            if (numDict.ContainsKey(nums[i])) numDict[nums[i]]++;
            else numDict[nums[i]] = 1;
        }

        foreach (var num in numDict.Keys) {
            if (numDict[num] > (nums.Length / 2)) return num;
        }

        return -1;
    }
}