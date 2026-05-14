# 🧠 Problem: 116. Populating Next Right Pointers in Each Node

- **Link:** [Problem Link](https://leetcode.com/problems/populating-next-right-pointers-in-each-node/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Since the tree is **perfect**, every node has both a left and right child.
- For every node:
  - `left.next = right`
  - `right.next = node.next?.left`
- The parent already contains enough information to connect children across subtrees, so no extra data structure is needed.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I realized the pattern quickly, so I did not have any struggle
- Only thing is the code structure could be more clean.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- BFS works in `O(n)` time but requires `O(w)` queue space.
- A cleaner recursive approach directly uses:
  - `node.left.next = node.right`
  - `node.right.next = node.next?.left`
- The most optimal follow-up solution uses already-established `next` pointers to traverse levels iteratively and achieves `O(1)` extra space.

---

## ⏱️ Complexity
- **Time:** `O(n)`
- **Space:** `O(h)` (recursion stack, leetcode dismissing anyway)

---

## 🧠 When to Use This Pattern
- Tree problems where neighboring nodes need relationships established.
- Problems where parent information can help derive child relationships.
- Perfect binary trees often contain structural guarantees that remove the need for additional storage.

### 💡 Mental trigger:
> "Can I use already-known parent or sibling relationships instead of storing nodes in a queue?"


---

## 🔗 Similar Questions
- [Populating Next Right Pointers in Each Node II](https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/)
- [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view/)
- [Cycle Length Queries in a Tree](https://leetcode.com/problems/cycle-length-queries-in-a-tree/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2