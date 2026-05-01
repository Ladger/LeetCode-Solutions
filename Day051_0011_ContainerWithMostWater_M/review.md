# 🧠 Problem: 11. Container With Most Water

- **Link:** [Problem Link](https://leetcode.com/problems/container-with-most-water/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The area is determined by min(height[l], height[r]) * (r - l).
- The shorter line is always the limiting factor, so moving the taller line cannot improve the result.
- Therefore, always move the pointer pointing to the smaller height to potentially find a better container.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Yesterday, I solved trapping rain water. Therefore, the pattern looked similar to me.
- I solved under 5 minutes so there was not any struggle

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use two pointers: l = 0, r = n - 1
- While l < r:
    - Compute area: area = min(height[l], height[r]) * (r - l)
    - Update max area
    - Move the pointer with the smaller height
- Repeat until pointers meet

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When maximizing/minimizing something between two ends of an array
- When the result depends on a pair of values + distance
- When you can eliminate choices greedily based on a limiting factor
- When moving one pointer can provably discard worse solutions

---

## 🔗 Similar Questions
- [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/)
- [Maximum Tastiness of Candy Basket](https://leetcode.com/problems/maximum-tastiness-of-candy-basket/)
- [House Robber IV](https://leetcode.com/problems/house-robber-iv/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2