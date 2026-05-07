public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> h = new();

        while (n != 1) {    
            int sum = 0;
            while (n > 0)
            {
                sum += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }

            n = sum;
            if (h.Contains(n)) return false;
            
            h.Add(n);
        } 

        return true;
    }
}