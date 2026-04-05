# 🧠 Problem: 200. Number of Islands

- **Link:** [Problem Link](https://leetcode.com/problems/number-of-islands/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- DFS/BFS
- Union-find
- Matrix

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The main idea is if we find a part of island ('1'), we should check if it is visited.
- If it is not visited we should run DFS or BFS in order to traverse the neighbor parts that forms the island.
- Mark the parts as visited so we do not traverse again.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In my first iteration (in implementation BFS), I was using the visited boolean matrix.
- However, it is not sincerely necessary since we can just mark as '0' in grid matrix.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate through grid, check is it '1'
- If it is '1' execute BFS or DFS and traverse all the nighbor '1's
- Mark the traversed elements as '0'
- If BFS add the neighbors to the queue, if DFS recurse through the furthest element.

---

## ⏱️ Complexity
- **Time:** O(N x M)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- You are given a grid/matrix
- Need to count connected components
- Movement is in 4 or 8 directions
- Keywords:
"islands",
"regions",
"clusters",
"connected components"

---

## 🔗 Similar Questions
- [130. Surrounded Regions](https://leetcode.com/problems/surrounded-regions/)
- [419. Battleships in a Board](https://leetcode.com/problems/battleships-in-a-board/)
- [695. Max Area of Island](https://leetcode.com/problems/max-area-of-island/)
- [1905. Count Sub Islands](https://leetcode.com/problems/count-sub-islands/)
- [1992. Find All Groups of Farmland](https://leetcode.com/problems/find-all-groups-of-farmland/)
- [2316. Count Unreachable Pairs of Nodes in an Undirected Graph](https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph/)
- [2658. Maximum Number of Fish in a Grid](https://leetcode.com/problems/maximum-number-of-fish-in-a-grid/)
- [3619. Count Islands With Total Value Divisible by K](https://leetcode.com/problems/count-islands-with-total-value-divisible-by-k/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2