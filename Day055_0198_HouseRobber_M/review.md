# 🧠 Problem: 1988. House Robber

- **Link:** [Problem Link](https://leetcode.com/problems/house-robber/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Dynamic Programming

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- At each house, you have two choices:
    - Skip it → keep previous max (dp[i-1])
    - Rob it → add current value to dp[i-2]

So: dp[i] = max(dp[i-1], dp[i-2] + nums[i])

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initialized mem[1] incorrectly as nums[1] instead of max(nums[0], nums[1])
- Didn’t fully trust the DP definition → unnecessary comparison at the end
- Slight confusion about why DP is needed when O(1) is possible

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Realized DP array can be reduced to two variables
- Only need:
    - prev1 → dp[i-1]
    - prev2 → dp[i-2]

- Final transition: current = max(prev1, prev2 + nums[i])

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When elements cannot be chosen together (adjacent restriction)
- When each step is a binary decision (take or skip)
- When current state depends on previous 1–2 states

### 💡 Mental trigger:
“At each index, do I take this and skip previous, or skip this and keep previous?”

---

## 🔗 Similar Questions
- [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)
- [House Robber II](https://leetcode.com/problems/house-robber-ii/)
- [House Robber III](https://leetcode.com/problems/house-robber-iii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2