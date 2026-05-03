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
    public void Flatten(TreeNode root) {
        while (root != null) {
            if (root.left != null) {
                TreeNode curr = root.left;
                while (curr.right != null) {
                    curr = curr.right;
                }

                curr.right = root.right;
                root.right = root.left;
                root.left = null;
            }

            root = root.right;
        }
    }
}