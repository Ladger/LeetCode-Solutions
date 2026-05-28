# 🧠 Problem: 173. Binary Search Tree Iterator

- **Link:** [Problem Link](https://leetcode.com/problems/binary-search-tree-iterator/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Stack
- Design
- BST
- Iterator

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Simulate an inorder traversal lazily using a stack.
- The stack always stores the path to the next smallest node.
- After consuming a node, process its right subtree by pushing its leftmost path.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- None.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of storing the entire inorder traversal beforehand, maintain only the necessary traversal state.
- Use a stack to mimic recursive inorder traversal.
- Each node is pushed and popped exactly once, giving amortized O(1) Next() operations while using only O(h) memory.

---

## ⏱️ Complexity
- **Time:**
  - Next() - Amortized O(1)
  - HasNext() - O(1)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When you need incremental traversal instead of processing the whole tree at once.
- When simulating recursion iteratively.
- When implementing iterators over trees with limited memory usage.

### 💡 Mental trigger:
“I need the next inorder node at any time without storing the full traversal.”

---

## 🔗 Similar Questions
- [Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/)
- [Peeking Iterator](https://leetcode.com/problems/peeking-iterator/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2