# 🧠 Problem: 61. Rotate List

- **Link:** [Problem Link](https://leetcode.com/problems/rotate-list/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Two Pointers

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The idea is we are moving last k elements in front of the list
- In linked lists, we can achieve this by just removing and adding one connection each

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Originally, I was unaware that the structure is linked list.
- Therefore my first run was implementing the solution like solving the rotate array.
- In my first submission, traversing logic was a bit complex. I rewrite as cleaner traversal

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- First traverse the whole list to get length and tail.
- Apply modulo operation on shift amount by length.
- Connect the tail to the existing head. Now we have circular linked list.
- Traverse the new tail's position, which is length - k - 1.
- Set the new head as tail's next node and set tail.next as null.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When dealing with rotations in linked lists.
- When a problem involves reordering from end to front.
- Useful in problems where relative position matters more than absolute traversal.

---

## 🔗 Similar Questions
- [Rotate Array](https://leetcode.com/problems/rotate-array/)
- [Split Linked List in Parts](https://leetcode.com/problems/split-linked-list-in-parts/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2