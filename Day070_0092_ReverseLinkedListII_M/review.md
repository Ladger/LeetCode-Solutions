# 🧠 Problem: 92. Reverse Linked List II

- **Link:** [Problem Link](https://leetcode.com/problems/reverse-linked-list-ii)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Split the list into 3 parts:
  - nodes before left
  - nodes between left and right
  - nodes after right
- Reverse only the middle section using the standard linked list reversal technique.
- Reconnect the reversed part back to the untouched sections.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Trying to traverse, reverse, and reconnect all inside one loop made pointer tracking confusing.
- Forgot that when left == 1, there is no node before the reversed section.
- Accidentally accessed beforeLeft.next when beforeLeft was null.
- Mixing traversal pointers (prev) with reversal pointers too early caused logical confusion.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- First move to the left position and save:
  - node before left
  - first node of the reversed segment
- Reverse exactly right - left + 1 nodes.
- Reconnect:
  - beforeLeft.next -> reversedHead
  - leftNode.next -> remainingList
- If reversing starts from head (left == 1), update head directly.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When only part of a linked list must be reversed.
- When a problem asks for in-place linked list modification.
- Useful for k-group reversal and segment manipulation problems.

### 💡 Mental trigger:
“Reverse only a section/subrange of a linked list.”
“Reconnect reversed segment back into original list.”

---

## 🔗 Similar Questions
- [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2