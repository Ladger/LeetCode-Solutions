# 🧠 Problem: 62. Longest Consecutive Sequence

- **Link:** [Problem Link](https://leetcode.com/problems/longest-consecutive-sequence/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Union-Find
- Hashset

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Store all numbers inside a HashSet for O(1) lookup.
- Only start counting when the current number is the beginning of a sequence (num - 1 does not exist).
- Expand forward using a while loop to count the consecutive streak.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried to merge sequences using `Dictionary<int, HashSet<int>>`
- Merging only updated references for edge values, causing inconsistent sets for older elements.
- Missed the fact that non-starting elements are skipped entirely.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of storing full sequences, only track whether numbers exist.
- Detect sequence starters with: !set.Contains(num - 1)
- Then expand forward: while (set.Contains(current + 1))
- Each number is visited at most once across all expansions, keeping the total complexity linear.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(k) - number of unique elements

---

## 🧠 When to Use This Pattern
- When the problem involves:
    - consecutive values
    - fast existence checks
    - grouping/sequences without sorting
- Useful when sorting would increase complexity unnecessarily.

### 💡 Mental trigger:
“Can I use a HashSet and only start processing from valid sequence beginnings?”

---

## 🔗 Similar Questions
- [Find Three Consecutive Integers That Sum to a Given Number](https://leetcode.com/problems/find-three-consecutive-integers-that-sum-to-a-given-number/)
- [Maximum Consecutive Floors Without Special Floors](https://leetcode.com/problems/maximum-consecutive-floors-without-special-floors/)
- [Length of the Longest Alphabetical Continuous Substring](https://leetcode.com/problems/length-of-the-longest-alphabetical-continuous-substring/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2