public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0) return;
        if (m == 0) {
            Array.Copy(nums2, nums1, nums2.Length);
            return;
        }

        int l = m - 1;
        int r = n - 1;
        int k = m + n - 1;
        while (r >= 0) {
            if (l >= 0 && nums1[l] > nums2[r]) {
                nums1[k] = nums1[l];
                l--;
            }
            else {
                nums1[k] = nums2[r];
                r--;
            }
            
            k--;
        }
    }
}