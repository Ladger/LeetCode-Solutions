# 🧠 Problem: 21. Merge Two Sorted Lists

- **Link:** [Problem Link](https://leetcode.com/problems/merge-two-sorted-lists/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Recursion

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use a dummy node to simplify edge cases.
- Maintain a pointer (op) that builds the merged list.
- Compare current nodes of both lists and always attach the smaller one, then move forward.
- At the end, attach the remaining part of the non-empty list.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Trying to create new nodes instead of reusing existing ones (unnecessary overhead).
- Missing the benefit of a dummy node → leads to messy head handling.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate until one list node becomes null
- Compare list1 and list2 nodes, add the smaller one into the op node's next
- And move forward on the list which is smaller one

---

## ⏱️ Complexity
- **Time:** O(m + n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When merging two sorted sequences
- When working with linked lists and pointer manipulation
- Classic building block for:
    - Merge Sort on Linked Lists
    - K Sorted Lists (extension with heap)

---

## 🔗 Similar Questions
- [23. Merge k Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/)
- [88. Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/)
- [148. Sort List](https://leetcode.com/problems/sort-list/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2