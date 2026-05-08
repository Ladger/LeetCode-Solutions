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
    int result = 0;
    public int SumNumbers(TreeNode root) {
        CreateNumber(root, 0);
        return result;
    }

    private void CreateNumber(TreeNode root, int prefix) {
        if (root == null) return;

        int shiftedVal = prefix * 10;
        shiftedVal += root.val;

        if (root.left == null && root.right == null) result += shiftedVal; 

        CreateNumber(root.left, shiftedVal);
        CreateNumber(root.right, shiftedVal);
    }
}