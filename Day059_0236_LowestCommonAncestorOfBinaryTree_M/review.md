# 🧠 Problem: 236. Lowest Common Ancestor of a Binary Tree

- **Link:** [Problem Link]()

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- DFS
- Binary Tree

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use postorder DFS to search both subtrees.
- If both left and right recursive calls return non-null, the current node is the Lowest Common Ancestor.
- If only one side returns non-null, propagate that node upward.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially returned null when only one subtree contained p or q, which discarded useful information.
- Struggled with how recursion can “carry” discovered nodes upward without explicitly tracking counts or multiple nodes.
- Compared node values instead of node references at first.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The recursive return value itself represents important information:
    - null → nothing found
    - p or q → one target found
    - current node → LCA found
- No extra data structures are needed.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When a tree problem asks for information that depends on both left and right subtrees.
- When recursive calls can return partial answers upward.
- Useful for “find node”, “merge subtree information”, or “lowest shared ancestor” style problems.

### 💡 Mental trigger:
“Can each recursive call return useful information upward that parent nodes combine?”

---

## 🔗 Similar Questions
- [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/)
- [Find Players With Zero or One Losses](https://leetcode.com/problems/find-players-with-zero-or-one-losses/)
- [Step-By-Step Directions From a Binary Tree Node to Another](https://leetcode.com/problems/step-by-step-directions-from-a-binary-tree-node-to-another/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2