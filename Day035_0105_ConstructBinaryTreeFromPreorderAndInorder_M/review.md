# 🧠 Problem: 105. Construct Binary Tree from Preorder and Inorder Traversal

- **Link:** [Problem Link](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/)

## 🧩 Pattern / Topic
- Binary Tree  
- Array
- Hash Table
- Divide and Conquer

---

## 💡 Key Idea
- Preorder gives the root first.
- Inorder splits the tree into left and right subtrees.
- Use a hashmap to quickly find the root index in inorder and recursively build left and right subtrees.

---

## ❌ Mistakes / Struggles
- At my first attempt, I was using a linear search to find right inorder position of the start index.
- It causes O(n^2) time complexity for skewed trees.
- I couldn't find how to determine the starting index of the right subtree in preorder. However than I used left subtree size in order to find it.
- Forgetting the base case (`l > r`).

---

## 🔁 Better / Optimal Solution
- Use a hashmap for inorder index lookup → O(1).
- Track preorder index manually using subtree size 
- Avoid scanning inorder repeatedly.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When reconstructing a tree from traversal orders.
- When one traversal gives root order (pre/post) and another gives structure (inorder).
- When recursive tree building with index boundaries is needed.

---

## 🔗 Similar Questions
- [Construct Binary Tree from Inorder and Postorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/)
- [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/)
- [Convert Sorted Array to Binary Search Tree](https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2