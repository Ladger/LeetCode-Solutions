# 🧠 Problem: 322. Coin Change

- **Link:** [Problem Link](https://leetcode.com/problems/coin-change/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Dynamic Programming
- BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Define: dp[i] = minimum coins needed to form amount i
- For every amount, try using each coin as the last coin: dp[i] = min(dp[i], dp[i - coin] + 1)
- If a previous amount is impossible, skip it.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially confused base case initialization
- Tried using -1 as impossible state, which conflicted with Math.Min
- Misunderstood why impossible states should start as infinity
- Needed to realize: dp[0] = 0
    - means: amount 0 requires 0 coins
    - Took time to understand why: dp[i - coin] + 1

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Initialize all states as impossible (int.MaxValue)
- Use bottom-up DP to build smaller amounts first
- Skip invalid previous states to avoid overflow
- Final answer: return -1 if amount is still impossible
- Optimized transition: if (dp[i - coin] != int.MaxValue)

---

## ⏱️ Complexity
- **Time:** O(m * n)
- **Space:** O(m)

m: amount
n: number of coins

---

## 🧠 When to Use This Pattern
- When the problem asks for:
    - minimum operations
    - minimum steps
    - minimum items needed
- When current state can be built from smaller states
- When choices can be reused unlimited times

### 💡 Mental trigger:
“What is the minimum cost/steps needed to reach this state?”
“If I use this choice as my LAST move, what happens?”

---

## 🔗 Similar Questions
- [Minimum Cost For Tickets](https://leetcode.com/problems/minimum-cost-for-tickets/)
- [Maximum Value of K Coins From Piles](https://leetcode.com/problems/maximum-value-of-k-coins-from-piles/)
- [Minimum Number of Operations to Convert Time](https://leetcode.com/problems/minimum-number-of-operations-to-convert-time/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2