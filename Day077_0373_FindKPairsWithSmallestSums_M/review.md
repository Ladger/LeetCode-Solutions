# 🧠 Problem: 373. Find K Pairs with Smallest Sums

- **Link:** [Problem Link](https://leetcode.com/problems/find-k-pairs-with-smallest-sums/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Heap (Priority Queue)

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Treat each pair (i, j) as a state in a 2D grid where each cell has cost nums1[i] + nums2[j].
- Use a min-heap (PriorityQueue) to always extract the smallest available pair.
- Expand only two neighbors: (i+1, j) and (i, j+1).
- Use a visited set to avoid processing the same (i, j) multiple times.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried to build a full heap of all pairs (O(n*m)) → too large.
- Initially attempted custom heap on raw values instead of states.
- Missing:
  - bounds checks for (i+1, j) and (i, j+1)
  - visited set timing (duplicate states issue)
  - Misunderstanding how PriorityQueue orders elements (priority-based, not element-based)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use PriorityQueue<(i, j), sum>:
  - element = coordinates (i, j)
  - priority = nums1[i] + nums2[j]
- Initialize with (0,0)
- Repeat k times:
  - extract smallest sum pair
  - push next valid states:
    - (i+1, j)
    - (i, j+1)
- Maintain visited to ensure each state is processed once

---

## ⏱️ Complexity
- **Time:** O(klogk)
- **Space:** O(k)

---

## 🧠 When to Use This Pattern
- When you need the k smallest/largest combinations from multiple sorted arrays
- When the problem can be modeled as a sorted matrix or grid
- When local expansion can generate globally optimal next candidates

### 💡 Mental trigger:
“I need the next smallest combination, but generating all pairs is too large → use a heap over states.”

---

## 🔗 Similar Questions
- [Kth Smallest Element in a Sorted Matrix](https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/)
- [Find K-th Smallest Pair Distance](https://leetcode.com/problems/find-k-th-smallest-pair-distance/)
- [Kth Smallest Product of Two Sorted Arrays](https://leetcode.com/problems/kth-smallest-product-of-two-sorted-arrays/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2