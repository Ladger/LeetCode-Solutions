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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return CheckPath(root, targetSum, 0);
    }

    public bool CheckPath(TreeNode root, int targetSum, int total) {
        if (root == null) return false;
        if (root.left == null && root.right == null) {
            return targetSum == total + root.val;
        }

        return CheckPath(root.left, targetSum, total + root.val) || CheckPath(root.right, targetSum, total + root.val);
    }
}