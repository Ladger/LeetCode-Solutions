# 🧠 Problem: 129. Sum Root to Leaf Numbers

- **Link:** [Problem Link](https://leetcode.com/problems/sum-root-to-leaf-numbers)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Tree
- DFS
- Binary Tree

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- While traversing from root to leaf, carry the current number formed so far.
- At each node, shift the previous number left by one digit (current * 10) and add the node’s value.
- When reaching a leaf node, add the completed number to the final answer.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Using a global variable works, but returning values recursively often leads to cleaner code (Implement in the review session)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of storing paths in arrays/strings, build the number mathematically during traversal.
- Recursive return-based DFS avoids mutable global state and keeps the logic more functional and readable.
- Once a leaf is reached, immediately return its formed value.
- Example transition: current = current * 10 + node.val

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When traversing a tree while carrying information from parent → child.
- Problems where each path builds a cumulative value/state.
- Useful for:
    - path sums
    - string/path construction
    - prefix accumulation
    - root-to-leaf computations

### 💡 Mental trigger:
- “Can I pass the current path state through DFS instead of storing the whole path?”
- “Can the answer for a child be built from the parent’s partial result?”

---

## 🔗 Similar Questions
- [Path Sum](https://leetcode.com/problems/path-sum/)
- [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/)
- [Smallest String Starting From Leaf](https://leetcode.com/problems/smallest-string-starting-from-leaf/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2