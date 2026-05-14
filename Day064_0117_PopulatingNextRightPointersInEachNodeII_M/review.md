# 🧠 Problem: 117. Populating Next Right Pointers in Each Node II

- **Link:** [Problem Link](https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Traverse the current level using already-established `next` pointers.
- While traversing, construct the next level as a linked list.
- Keep track of:
  - `nextHead` → first node in the next level
  - `prev` → previously connected child node

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried extending the solution from 116 directly.
- Focused on connecting sibling nodes (`left -> right`) instead of building an entire level.
- Assumed the next node would always be nearby.
- Forgot that missing children break local relationships.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The tree itself can provide traversal infrastructure through `next` pointers.
- Instead of using a queue, process one level and simultaneously build the next one.
- This achieves level-order traversal without extra storage.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Level-order traversal without using a queue
- Problems where relationships can be reused as traversal paths
- Tree problems that require connecting or building neighbor relationships

### 💡 Mental trigger:
"Can I traverse the current level and construct the next one at the same time?"
"Can previously established pointers replace extra memory?"

---

## 🔗 Similar Questions
- [Populating Next Right Pointers in Each Node](https://leetcode.com/problems/populating-next-right-pointers-in-each-node/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2