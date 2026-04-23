public class Solution {
    public string ReverseWords(string s) {
        char[] arr = s.ToCharArray();

        int l = 0;
        int r = arr.Length - 1;
        while (l < r) {
            char temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;

            l++;
            r--;
        }

        l = 0;
        r = 0;
        while (r < arr.Length) {
            while (l != arr.Length && arr[l] == ' ') {
                l++;
                r++;
            }

            while (r != arr.Length && arr[r] != ' ') {
                r++;
            }

            int end = r - 1;
            while (l < end) {
                char temp = arr[l];
                arr[l] = arr[end];
                arr[end] = temp;

                l++;
                end--;
            }

            l = r;
        }

        l = 0;
        r = 0;
        while (r < arr.Length) {
            while (r != arr.Length && arr[r] == ' ') {
                r++;
            }

            while (r != arr.Length && arr[r] != ' ') {
                arr[l] = arr[r];

                l++;
                r++;
            }

            while (r != arr.Length && arr[r] == ' ') {
                r++;
            }

            if (r != arr.Length) {
                arr[l] = ' '; 

                l++;
            }  
        }

        return new string(arr, 0, l);
    }
}