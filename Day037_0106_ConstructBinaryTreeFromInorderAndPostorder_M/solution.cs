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

    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }

        return Build(postorder, postorder.Length - 1, 0, postorder.Length - 1);
    }

    private TreeNode Build(int[] postorder, int rootIndex, int l, int r) {
        if (l > r) return null;

        int rootVal = postorder[rootIndex];
        TreeNode root = new(rootVal);

        int index = inorderMap[rootVal];
        int rightSize = r - index;

        root.right = Build(postorder, rootIndex - 1, index + 1, r);
        root.left = Build(postorder, rootIndex - rightSize - 1, l, index - 1);

        return root;
    }
}