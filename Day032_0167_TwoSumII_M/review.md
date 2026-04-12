# 🧠 Problem: 167. Two Sum II - Input Array Is Sorted

- **Link:** [Problem Link](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers
- Binary Search

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use two pointers:
    One at the start (l)
    One at the end (r)
- Adjust pointers based on the sum:
    Too big → move right pointer left
    Too small → move left pointer right

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In my first attempt, I only thought about Brute Force within constant space.
- Forgetting the array is sorted, so I missed the two-pointer optimization

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use two pointers instead of brute force obviously
- Iterate as long as left pointer is smaller than the right pointer
- Adjust the pointers based on the sum result compared to the target

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When:
    The array is sorted
    You need to find a pair/triplet with a condition

- Strong signal:
    “Sorted array” → think Two Pointers

---

## 🔗 Similar Questions
- [1. Two Sum](https://leetcode.com/problems/two-sum/)
- [653. Two Sum IV - Input is a BST](https://leetcode.com/problems/two-sum-iv-input-is-a-bst/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2