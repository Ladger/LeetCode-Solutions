# 🧠 Problem: 88. Merge Sorted Array

- **Link:** [Problem Link](https://leetcode.com/problems/merge-sorted-array/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers
- In-place Algorithm

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- nums1 already has enough space to hold both arrays.
- Instead of merging from the front (which causes overwrites), merge from the back.
- Compare the largest elements and place them at the end.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At my first attempt, I created result array and write the elements on that array.
- It causes unnecessary O(n + m) space complexity.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use three pointers:
    1. i = m - 1 → last valid element in nums1
    2. j = n - 1 → last element in nums2
    3. k = m + n - 1 → position to fill in nums1
- Iterate backwards:
    1. Place the larger of nums1[i] and nums2[j] at nums1[k]
    2. Move pointers accordingly

---

## ⏱️ Complexity
- **Time:** O(m + n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When merging two sorted arrays in-place
- When one array has extra buffer space
- When forward iteration causes overwrite issues

---

## 🔗 Similar Questions
- [21. Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/)
- [283. Move Zeroes](https://leetcode.com/problems/move-zeroes/)
- [977. Squares of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2