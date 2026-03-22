public class Solution {
    public string AddBinary(string a, string b) {
        char[] c1 = a.ToCharArray();
        char[] c2 = b.ToCharArray();

        Array.Reverse(c1);
        Array.Reverse(c2);

        int i = 0;
        int carry = 0;
        List<char> result = new();

        while (i < c1.Length || i < c2.Length || carry != 0) {
            int sum = carry;

            if (i < c1.Length) sum += c1[i] - '0';
            if (i < c2.Length) sum += c2[i] - '0';

            result.Add((char)((sum % 2) + '0'));
            carry = sum / 2;

            i++;
        }

        result.Reverse();
        return new string(result.ToArray());
    }
}