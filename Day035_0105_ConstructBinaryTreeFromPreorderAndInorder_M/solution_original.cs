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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build(preorder, inorder, 0, 0, preorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int[] inorder, int start, int l, int r) {
        if (l > r) return null;

        TreeNode root = new(preorder[start]);

        int index = 0;
        for (int i = l; i <= r; i++) {
            if (preorder[start] == inorder[i]) index = i;
        }        

        root.left = Build(preorder, inorder, start + 1, l, index - 1);
        root.right = Build(preorder, inorder, start + (index - l) + 1, index + 1, r);

        return root;
    }
}