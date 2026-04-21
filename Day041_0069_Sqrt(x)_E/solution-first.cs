public class Solution {
    public int MySqrt(int x) {
        int result = 1;
        while ((long)result * result <= x) {
            result++;
        }

        return result - 1;
    }
}