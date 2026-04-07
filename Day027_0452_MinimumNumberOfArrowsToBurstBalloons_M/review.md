# 🧠 Problem: 452. Minimum Number of Arrows to Burst Balloons

- **Link:** [Problem Link](https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Sort
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Main idea is find overlaps within narrowing interval as we iterate. Greed approach is valid for this problem

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At my first attempt, I implemented the same algorithm without narrowing interval.
- I had interval list that keeps the concecutive intervals.
- Therefore, a new interval should check the whole concecutive intervals one by one, that leads O(n^2) solution.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of keeping the concecutive interval list, I just keep the narrowInterval for check the overlaps
- In every iteration I check the current one overlaps with the narrowInterval.
- If it does I rearrange the finish time of the narrowInterval that is minimum between finish time of current and narrowInterval.
- If it is not overlapping, I increase the shots counter and set the narrowInterval with current one as fresh start of new narrowInterval

---

## ⏱️ Complexity
- **Time:** O(nlogn)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Whenever you have a set of intervals (or ranges) and need to combine overlapping or adjacent ones into a minimal set.
- When you can sort the input and make local optimal decisions that lead to a global optimum.

---

## 🔗 Similar Questions
- [435. Non-overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2