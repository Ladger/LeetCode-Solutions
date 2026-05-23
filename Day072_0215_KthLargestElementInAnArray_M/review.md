# 🧠 Problem: 215. Kth Largest Element in an Array

- **Link:** [Problem Link](https://leetcode.com/problems/kth-largest-element-in-an-array/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Divide and Conquer
- Sorting
- Heap (Priority Queue)
- Quickselect

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Build a max heap first
- Therefore extract k element from that heap
- The Kth element will give the answer since heap property guarantees you the extracted will be the max value of that array

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In ExtractMax, the heap size was not shrinking, so heap operations still considered removed elements.
- Used nums.Length instead of tracking a separate heapSize.
- BuildMaxHeap unnecessarily heapified leaf nodes.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The heap solution works well and is intuitive for “top K” style problems.
- A better average-time solution is Quickselect, which solves the problem in:
  - Average: O(n)
  - Worst case: O(n²)
- Heap is often easier to implement correctly and generalizes nicely to streaming / dynamic top-k problems.

---

## ⏱️ Complexity
- **Time:** O(nlogn)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Use heap when:
  - You repeatedly need the maximum/minimum element.
  - The problem asks for:
    - kth largest/smallest
    - top k elements
    - dynamically updating priorities
- Heaps are especially useful when:
  - You do not need the entire array sorted.
  - You only care about a subset of largest/smallest elements.

### 💡 Mental trigger:
“I need repeated access to the current max/min efficiently.”

---

## 🔗 Similar Questions
- [Wiggle Sort II](https://leetcode.com/problems/wiggle-sort-ii/)
- [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/)
- [Third Maximum Number](https://leetcode.com/problems/third-maximum-number/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2