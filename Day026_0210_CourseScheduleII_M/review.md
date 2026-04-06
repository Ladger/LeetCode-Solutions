# 🧠 Problem: 210. Course Schedule II

- **Link:** [Problem Link](https://leetcode.com/problems/course-schedule-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- BFS/DFS
- Graph Theory
- Topological Sort

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- If we want to ensure there is possible course schedule, we should check there won't be any cycles.
We can achieve this by keeping the indegree of nodes, if we remove one node we should update if there is direction to adjacent.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I did not face any struggles since I was already built the Kahn's Algortihm on the first question.
- But i faced the issue that initializing the array causes creating 0's as much as the size, I forgot that.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I built a linked list list for keeping the adjacents. That has space complexity of O(V + E).
- I calculated indegree for each node in the graph.
- Therefore, I implemented the Kahn's algorithm for elimination 0-indegreed nodes from the graph.
- I added the top elements on the list
- At the end if numCourses and List.Count equals therefore return the order, if not return empty array

---

## ⏱️ Complexity
- **Time:** O(V + E)
- **Space:** O(V + E)

---

## 🧠 When to Use This Pattern
- When there are **dependencies between items** (A must be done before B)
- When the problem asks if it is possible to **complete all tasks / courses / jobs**
- When you need to detect a **cycle in a directed graph**
- When elements must be processed in a **valid order based on prerequisites**

---

## 🔗 Similar Questions
- [210. Course Schedule](https://leetcode.com/problems/course-schedule/description/)
- [630. Course Schedule III](https://leetcode.com/problems/course-schedule-iii/description/)
- [310. Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees/description/)
- [2392. Build a Matrix With Conditions](https://leetcode.com/problems/build-a-matrix-with-conditions/description/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2