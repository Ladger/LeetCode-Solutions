# 🧠 Problem: 27. Remove Element

- **Link:** [Problem Link](https://leetcode.com/problems/remove-element/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Keep two pointers: one for start of the array, other for end index of result array.
- If the start pointer equals val, put it end index. Then shrink end index by one.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In my first attempt, I forgot the edge case that is same valued array
- When it is the case, I got out of index caused by end index shrink. Because I was not iterating based on endIndex (I iterate length or array).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate until i reaches end index.
- Check the current element if it is equal value
    - If yes, loop while current i element equal val
    - swap the i element and end element, and mark -1 so it wont be bother again
    - Decrement end index by one
- Return end index + 1 for length of an result array.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern

- When you need to **remove elements in-place** without allocating extra memory.
- When the **order of elements does NOT matter**.
- When you can safely **swap unwanted elements with the end of the array**.
- When using a **shrinking window approach** (processing from start while reducing the valid end boundary).
- Common in problems involving:
  - Filtering elements in-place
  - Partitioning arrays
  - Two-pointer techniques with opposite directions

---

## 🔗 Similar Questions
- [26. Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/)
- [203. Remove Linked List Elements](https://leetcode.com/problems/remove-linked-list-elements/)
- [283. Move Zeroes](https://leetcode.com/problems/move-zeroes/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2