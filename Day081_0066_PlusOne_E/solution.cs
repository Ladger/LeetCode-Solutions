public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--) {
            int digit = digits[i] + carry;
            
            carry = digit == 10 ? 1 : 0;
            digits[i] = (digit != 10 ? digit : 0);
        }

        if (carry == 1) {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }   

        return digits;
    }
}