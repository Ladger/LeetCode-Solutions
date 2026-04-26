# 🧠 Problem: 3. Longest Substring Without Repeating Characters

- **Link:** [Problem Link](https://leetcode.com/problems/longest-substring-without-repeating-characters/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Hash Table
- String
- Sliding Window

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Maintain a sliding window that always contains unique characters.
- Expand the right pointer to include new characters.
- If a duplicate is found, shrink the window from the left until the duplicate is removed.
- Track the maximum window size during the process.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Early approach rebuilt the substring repeatedly (word string + nested loop), making it inefficient (O(n²) behavior).
- Clearing the whole set on duplicate instead of adjusting window incrementally.
- Losing the “window continuity” — restarting instead of shrinking.
- Overusing extra string storage instead of pointer-based tracking.
- Not recognizing that only the boundary (left pointer) needs adjustment, not full recomputation.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use two pointers (left, right) to represent a sliding window.
- Use a HashSet to track characters in the current window.
- When encountering a duplicate:
    - Move left forward and remove characters until duplicate is gone.
- Expand right normally and update max length as:
    - right - left + 1
- This avoids rebuilding strings and keeps operations O(1) per character.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(min(n, charset))

---

## 🧠 When to Use This Pattern
- Finding longest/shortest substring with constraints
- “No repeating / at most K distinct / condition-based window”
- Problems involving contiguous sequences in arrays or strings
- Optimization from brute-force O(n²) → O(n) sliding window

---

## 🔗 Similar Questions
- [992. Subarrays with K Different Integers](https://leetcode.com/problems/subarrays-with-k-different-integers/)
- [1695. Maximum Erasure Value](https://leetcode.com/problems/maximum-erasure-value/)
- [2260. Minimum Consecutive Cards to Pick Up](https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/)
- [2401. Longest Nice Subarray](https://leetcode.com/problems/longest-nice-subarray/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2