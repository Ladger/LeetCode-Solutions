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
public class BSTIterator {
    private Stack<TreeNode> s = new();

    public BSTIterator(TreeNode root) {
        TreeNode curr = root;
        
        while (curr != null) {
            s.Push(curr);
            curr = curr.left;
        }
    }
    
    public int Next() {
        TreeNode n = s.Pop();

        if (n.right != null) {
            TreeNode curr = n.right;
            while (curr != null) {
                s.Push(curr);
                curr = curr.left;
            }
        }

        return n.val;
    }
    
    public bool HasNext() {
        return s.Count != 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */