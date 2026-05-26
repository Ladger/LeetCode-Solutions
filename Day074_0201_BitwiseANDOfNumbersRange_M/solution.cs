public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int result = 0;
        for (int i = 31; i >= 0; i--) {
            int leftBit = (left >> i) & 1;
            int rightBit = (right >> i) & 1;
            
            if (leftBit != rightBit) break;

            result |= leftBit << i;
        }

        return result;
    }
}