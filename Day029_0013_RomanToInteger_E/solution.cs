public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> nums = new() {
            {'I',1}, {'V',5}, {'X',10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000}
        };

        if (s.Length == 1) return nums[s[0]];

        int result = nums[s[s.Length - 1]];
        char prev = s[s.Length - 1];
        for (int i = s.Length - 2; i >= 0; i--) {
            char current = s[i];
            
            if (nums[prev] > nums[current]) {
                result -= nums[current];
            }
            else {
                result += nums[current];
            }

            prev = current;
        }

        return result;
    }
}