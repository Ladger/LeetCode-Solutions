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
    int minDiff = int.MaxValue;
    TreeNode prev = null;

    public int GetMinimumDifference(TreeNode root) {
        Inorder(root);
        return minDiff;
    }

    private void Inorder(TreeNode root) {
        if (root == null) return;

        Inorder(root.left);

        if (prev != null) {
            minDiff = Math.Min(minDiff, Math.Abs(root.val - prev.val));
        }

        prev = root;

        Inorder(root.right);
    }
}