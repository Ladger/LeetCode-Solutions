# 🧠 Problem: 56. Merge Intervals

- **Link:** [Problem Link](https://leetcode.com/problems/merge-intervals/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Sort
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Should apply greedy optimization, if we detect it is overlapping with previous one it should be merged.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- The major mistake I have done was using RemoveAt() function on the *"solution-original.cs"*, 
- It causes O(n) search therefore algortihm becomes O(n^2) but it should be solvable at O(nlogn)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Sort all the list by their start time, this will allow us to assume start time always be the previous one
- Add first interval to our result list since it should be checked as previous one at the start
- Keep last and the current intervals in each iteration
- Check the finish times, if current has smaller or equal (problem says it can be acceptable) finish time than merge with the last interval
- If it is not smaller or equal than add the result list directly.

---

## ⏱️ Complexity
- **Time:** O(nlogn)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- Whenever you have a set of intervals (or ranges) and need to combine overlapping or adjacent ones into a minimal set.
- When you can sort the input and make local optimal decisions that lead to a global optimum.

---

## 🔗 Similar Questions
- [57. Insert Interval](https://leetcode.com/problems/insert-interval/)
- [986. Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/)
- [495. Teemo Attacking](https://leetcode.com/problems/teemo-attacking/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2