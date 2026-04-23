public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        int carry = 0;
        List<char> result = new();

        while (i >= 0 || j >= 0 || carry != 0) {
            int sum = carry;

            if (i >= 0) {
                sum += a[i] - '0';
                i--;
            }
            
            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }

            result.Add((char)((sum % 2) + '0'));
            carry = sum / 2;
        }

        result.Reverse();
        return new string(result.ToArray());
    }
}