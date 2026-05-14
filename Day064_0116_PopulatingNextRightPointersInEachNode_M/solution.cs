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
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        
        int leftH = GetHeight(root.left);
        int rightH = GetHeight(root.right);

        if (leftH == rightH) {
            return (1 << leftH) + CountNodes(root.right);
        }
        else {
            return (1 << rightH) + CountNodes(root.left);
        }
    }

    private int GetHeight(TreeNode root) {
        int height = 0;
        while (root != null) {
            height++;
            root = root.left;
        }

        return height;
    }
}