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
    int counter;
    int result = -1;

    public int KthSmallest(TreeNode root, int k) {
        counter = k;
        Inorder(root); 
        return result;   
    }

    private void Inorder(TreeNode root) {
        if (root == null || counter == 0) return;

        Inorder(root.left);

        counter--;
        if (counter == 0) {
            result = root.val;
            return;
        }

        Inorder(root.right);
    }
}