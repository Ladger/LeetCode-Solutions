/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildBST(nums, 0, nums.Length - 1);
    }

    public TreeNode BuildBST(int[] nums, int l, int r) {
        if (l > r) return null;

        int m = (l + r) / 2;
        TreeNode node = new(nums[m]);

        node.left = BuildBST(nums, l, m - 1);
        node.right = BuildBST(nums, m+1, r);

        return node;
    }
}