public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        int l = 1;
        int r = x/2;

        while (l <= r) {
            int m = l + (r - l) / 2;

            long check = (long)m * m;
            if (check == x) return m;
            else if (check < x) l = m + 1;
            else r = m - 1;
        }

        return r;
    }
}