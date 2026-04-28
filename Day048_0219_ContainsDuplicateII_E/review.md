# 🧠 Problem: 219. Contains Duplicate II

- **Link:** [Problem Link](https://leetcode.com/problems/contains-duplicate-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Hash Table
- Sliding Window

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Track the last seen index of each number using a dictionary.
- When encountering a duplicate, check if the index difference ≤ k.
- If yes → return true, otherwise update the index and continue.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- It was a straighforward problem, so I did not have any struggle
- Although when I first wrote, I originally put dictionary as int,List 
- Which is unnecessary since we are checking sequentially and all need is last index of that number

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a Dictionary int, int to store last seen indices

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When you need to check duplicates within a limited range (k distance)
- When constraints involve “at most k distance apart”
- When tracking most recent occurrence is enough
- Sliding window is useful when the problem involves a fixed-size neighborhood

---

## 🔗 Similar Questions
- [217. Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)
- [220. Contains Duplicate III](https://leetcode.com/problems/contains-duplicate-iii/)
---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2