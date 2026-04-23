# 🧠 Problem: 26. Remove Duplicates from Sorted Array

- **Link:** [Problem Link](https://leetcode.com/problems/remove-duplicates-from-sorted-array/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers

---

## 💡 Key Idea
- The core insight is to maintain two pointers: a "slow" pointer (`j`) that tracks the end of the unique elements, and a "fast" pointer (`i`) that scans through the rest of the array. 
- Because the array is already sorted, all duplicates are grouped together. Whenever the fast pointer finds a value different from the slow pointer's value, you increment the slow pointer and overwrite it with the new unique value.

---

## ❌ Mistakes / Struggles
- I did not have any struggle through the question
- However my first attempt was foolish, I set same elements IntMax for eliminating instead of override.

---

## 🔁 Better / Optimal Solution
- Keep two pointers: one for read 'i', one fore write 'j'
- If the jth element and ith element is same, continue to iterate
- If they are different increase the j by one and write the ith element on it

---

## ⏱️ Complexity
- **Time:** O(n) 
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Whenever a problem asks you to modify an array "in-place" without creating a new array.
- When you need to filter elements, remove targets, or group specific items (like moving all zeros to the end) in a linear data structure.
- The "Sorted Array" keyword in the title is the biggest giveaway that comparing adjacent elements or using two pointers will be the key.

---

## 🔗 Similar Questions
- [27. Remove Element](https://leetcode.com/problems/remove-element/)
- [80. Remove Duplicates from Sorted Array II](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/)
- [283. Move Zeroes](https://leetcode.com/problems/move-zeroes/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2