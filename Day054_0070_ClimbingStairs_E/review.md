# 🧠 Problem: 70. Climbing Stairs

- **Link:** [Problem Link](https://leetcode.com/problems/climbing-stairs/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Math
- Dynammic Programming
- Memoization

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The number of ways to reach step n equals the sum of ways to reach the previous two steps.
- At each step, you either come from n-1 (1 step) or n-2 (2 steps).
- This forms a Fibonacci-like recurrence:
    - dp[i]=dp[i−1]+dp[i−2]

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Confusion about indexing (dp[0] = 1 feels unintuitive at first).
- Forgetting proper base cases (n <= 2).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The DP array can be optimized away since only the last two states are needed.
- Use two variables instead of an array → O(1) space.
- Example idea:
    - Keep track of:
    - ways to reach previous step
    - ways to reach step before that
    - Iteratively update forward.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When the current state depends on a fixed number of previous states.
- Problems asking for number of ways / combinations.
- When you can model choices like:
    - “come from previous state(s)”

### 💡 Mental trigger:
- “Number of ways to reach position i depends on previous positions”
    - Try Fibonacci / DP recurrence

---

## 🔗 Similar Questions
- [Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/)
- [Frog Jump II](https://leetcode.com/problems/frog-jump-ii/)
- [Find Number of Ways to Reach the K-th Stair](https://leetcode.com/problems/find-number-of-ways-to-reach-the-k-th-stair/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2