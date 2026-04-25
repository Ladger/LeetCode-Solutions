# 🧠 Problem: 209. Minimum Size Subarray Sum

- **Link:** [Problem Link](https://leetcode.com/problems/minimum-size-subarray-sum)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Binary Search
- Sliding Window
- Prefix Sum

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use a sliding window to maintain a running sum and dynamically adjust the window size.
- Expand the window until the sum is ≥ target, then shrink from the left to find the smallest valid subarray.
- Since all numbers are positive, shrinking the window always decreases the sum → makes the approach valid.
- Alternative approaches: Prefix Sum + Binary Search (O(n log n))

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Shrinking the window before making it valid.
- Using incorrect condition (> instead of >=).
- Not updating the result inside the shrinking loop.
- Incorrect “no solution” check (e.g., comparing with array length instead of using a sentinel like int.MaxValue).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Follow the standard sliding window structure:
    - Expand window (r++, add to sum)
    - While sum ≥ target:
    - Update minimum length
    - Shrink window (l++)
- Key improvement:
    - Only shrink after the condition is satisfied
    - Always update the answer inside the loop


---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Array contains only positive numbers
- You are asked for:
    - Minimum/maximum subarray length
    - Subarray satisfying a condition (≥ target, ≤ k, etc.)
- Keywords:
    - “continuous subarray”
    - “smallest / longest”
    - “sum constraint”

👉 Core pattern: expand → validate → shrink → update answer

---

## 🔗 Similar Questions
- [76. Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)
- [718. Maximum Length of Repeated Subarray](https://leetcode.com/problems/maximum-length-of-repeated-subarray/)
- [2233. Maximum Product After K Increments](https://leetcode.com/problems/maximum-product-after-k-increments/)
- [3364. Minimum Positive Sum Subarray ](https://leetcode.com/problems/minimum-positive-sum-subarray/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2