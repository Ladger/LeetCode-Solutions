# 🧠 Problem: 82. Remove Duplicates from Sorted List II

- **Link:** [Problem Link](https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Two Pointers

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Because the list is sorted, duplicates always appear in consecutive blocks. The goal is not to keep one copy, but to completely remove any value that appears more than once. So the key idea is to detect “runs” of equal values and skip the entire run instead of partially processing it.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Confusing this with the simpler “remove duplicates but keep one” problem.
- Trying to update the head manually instead of using a safe structural approach.
- Not consistently handling edge cases where duplicates occur at the beginning or end of the list.
- Risk of null pointer issues when checking next nodes without verifying existence first.
- Losing track of the correct previous valid node when skipping duplicate blocks.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The clean approach is to use a placeholder node before the head to simplify edge cases. 
- Maintain two pointers: one that tracks the last confirmed valid node, and another that scans through the list.
- When a duplicate sequence is detected, the scanning pointer advances until the entire block of that value is skipped. 
- The previous valid pointer only reconnects once a non-duplicate value is found. 
- This ensures all duplicate values are fully removed and the list remains correctly linked.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When a linked list is sorted and duplicate values form contiguous blocks.
- When you need to delete nodes based on frequency, not just value.
- When head removal is possible and you want to avoid special-case logic.

### 💡 Mental trigger:
“If duplicates come in groups and I must remove all occurrences, I should think in blocks, not nodes.”

---

## 🔗 Similar Questions
- [Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2