# 🧠 Problem: 122. Best Time to Buy and Sell Stock II

- **Link:** [Problem Link](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Greedy
- Dynamic Programming

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Core idea is simple, if you see the profit from the previous day just sell it and add the profit

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- It is not a struggle maybe but I just modificated the Best Time to Buy and Sell Stock questions' solution
- It has irrelevant min-max variables

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Recurese through list
- If current price is higher than the previous one, add to profit

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When you need to track minimum/maximum so far while iterating
- Classic greedy optimization where local best leads to global best

---

## 🔗 Similar Questions
- [122. Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)
- [123. Best Time to Buy and Sell Stock III](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/)
- [309. Best Time to Buy and Sell Stock with Cooldown](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/)
- [714. Best Time to Buy and Sell Stock with Transaction Fee](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2