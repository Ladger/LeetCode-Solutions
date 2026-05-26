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
    int globalMax = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return root.val;

        Recurse(root);
        
        return globalMax;
    }

    private int Recurse(TreeNode root) {
        if (root == null) return 0;

        int l = Recurse(root.left);
        int r = Recurse(root.right);
        
        l = Math.Max(0, l);
        r = Math.Max(0, r);

        int complete = l + r + root.val;
        int oneway = Math.Max(l, r) + root.val;

        globalMax = Math.Max(globalMax, complete);

        return oneway;
    }
}