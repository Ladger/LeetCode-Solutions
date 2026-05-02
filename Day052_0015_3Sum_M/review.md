# 🧠 Problem: 15. 3Sum

- **Link:** [Problem Link](https://leetcode.com/problems/3sum/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers
- Sorting

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Sort the array, then fix one element and use a two-pointer approach to find pairs that sum to the negative of that element.
- Avoid duplicates by skipping repeated values for i, l, and r during traversal.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried using result.Contains() to remove duplicates → failed due to reference comparison and inefficiency.
- Missed duplicate handling for l and r, causing repeated triplets.
- Struggled with boundary conditions when skipping duplicates (out-of-bounds and incorrect conditions like l < nums.Length instead of l < r).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Sort the array first.
- Iterate with index i, skipping duplicates.
- Use two pointers (l, r) to find valid pairs:
    - If sum < 0 → move l
    - If sum > 0 → move r
    - If sum == 0 → store triplet and skip duplicates safely within l < r window
- Avoid generating duplicates instead of filtering them afterward.

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(k) - "k" is the number of triplets for result

---

## 🧠 When to Use This Pattern
- When dealing with sorted arrays + pair/triplet sum problems
- When you need to reduce a problem like 3Sum → multiple 2Sum problems
- Useful when constraints allow sorting and require efficient pair searching

---

## 🔗 Similar Questions
- [Two Sum](https://leetcode.com/problems/two-sum/)
- [3Sum Closest](https://leetcode.com/problems/3sum-closest/)
- [4Sum](https://leetcode.com/problems/4sum/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2