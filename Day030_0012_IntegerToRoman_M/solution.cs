public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int, string> nums = new() {
            {1,"I"}, {4,"IV"}, {5,"V"}, {9,"IX"}, 
            {10,"X"}, {40,"XL"}, {50,"L"}, {90, "XC"}, 
            {100,"C"}, {400, "CD"}, {500,"D"}, {900, "CM"}, {1000,"M"}
        };
        
        int[] fractions = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        StringBuilder sb = new("");
        for (int i = 0; i < fractions.Length; i++) {
            int freq = num / fractions[i];
            for (int j = 0; j < freq; j++) {
                sb.Append(nums[fractions[i]]);
            }

            num %= fractions[i];
        }

        return sb.ToString();
    }
}