# 🧠 Problem: 57. Insert Interval

- **Link:** [Problem Link](https://leetcode.com/problems/insert-interval/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Sort

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Should recurse the list until find a overlap, then try to merge overlapping intervals, finally recurse the rest of the list to the result

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I tried implement the merge intervals approach first.
- I added the newInterval to the original array and sorted, then execute merge interval code
- However, it leads to O(nlogn) solution. I learnt we can achieve this on single pass O(n) solution

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I found out, we could do this in a single pass.
- There should be 3 while loops: until the overlaping intervals, overlapping intervals, rest of the intervals.
- All should be added a result list.
- In overlapping intervals loop, we are constantly checking while find a non-overlapping interval.
- As we iterate, we must update the new intervals boundry by the interval at that current iteration.
- In other words, we are trying to enlength the newInterval with overlapping intervals.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- Whenever you have a set of intervals (or ranges) and need to combine overlapping or adjacent ones into a minimal set.
- When you can sort the input and make local optimal decisions that lead to a global optimum.

---

## 🔗 Similar Questions
- [56. Merge Intervals](https://leetcode.com/problems/merge-intervals/)
- [986. Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/)
- [495. Teemo Attacking](https://leetcode.com/problems/teemo-attacking/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2