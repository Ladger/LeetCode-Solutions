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
    private Dictionary<int, int> inorderMap = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }

        return Build(preorder, 0, 0, preorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int start, int l, int r) {
        if (l > r) return null;

        int rootVal = preorder[start];
        TreeNode root = new(rootVal);

        int index = inorderMap[rootVal];
        int leftSize = index - l;

        root.left = Build(preorder, start + 1, l, index - 1);
        root.right = Build(preorder, start + leftSize + 1, index + 1, r);

        return root;
    }
}