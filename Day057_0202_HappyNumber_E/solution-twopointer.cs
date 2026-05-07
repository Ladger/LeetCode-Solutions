public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = GetSum(n);
        while (fast != 1 && slow != fast) {    
            slow = GetSum(slow);
            fast = GetSum(GetSum(fast));
        } 

        return fast == 1;
    }

    private int GetSum(int n) {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}