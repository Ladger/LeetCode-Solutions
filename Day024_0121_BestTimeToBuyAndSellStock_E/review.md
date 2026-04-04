# 🧠 Problem: 121. Best Time to Buy and Sell Stock

- **Link:** [Problem Link](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Greedy
- Sliding Window

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Track the minimum price so far (best day to buy).
- At each step, calculate the profit if sold today.
- Update the maximum profit accordingly.
- If a lower price appears, update the buying point.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At the first attempt, i try to search for all buy-sell pairs that is minIndex < maxIndex
- It is an inefficient solution that makes the solution O(n^2)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Optimal solution is searching array in one pass
- Each iteration we are looking for three questions; 
1. Is there a minimum element than the current one?
2. Is there a maximum element than the current one?
3. Does the current min-max pair makes the profit larger than before? 

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
- [122. Best Time to Buy and Sell Stock II](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/)
- [123. Best Time to Buy and Sell Stock III](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/)
- [309. Best Time to Buy and Sell Stock with Cooldown](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/)
- [714. Best Time to Buy and Sell Stock with Transaction Fee](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2