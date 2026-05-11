# 🧠 Problem: 300. Longest Increasing Subsequence

- **Link:** [Problem Link](https://leetcode.com/problems/longest-increasing-subsequence/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Binary Search
- Dynamic Programming

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Define: dp[i] = length of the longest increasing subsequence ending at index i

- For every index i, look at all previous indices j:
    - if nums[j] < nums[i], then nums[i] can extend the subsequence ending at j.
- Transition:
    - dp[i] = Math.Max(dp[i], dp[j] + 1)

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially approached the problem greedily by building one increasing sequence
- Assumed taking the next bigger number is always optimal
- Struggled understanding why greedy fails for subsequences
- Felt overwhelmed by the shift from local DP (i-1, i-2) to comparing against all previous states
- Needed time to understand: “best subsequence ending at i”

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Initialize all dp[i] to 1, every number alone is a valid subsequence
- For each i, try extending all previous valid subsequences
- Keep track of the global maximum length

- There is also a more optimal: O(n log n), skipped for now to focus on understanding the DP formulation first. Revisit during review session.

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When current state depends on comparing against many previous states
- When building:
    - longest chain
    - longest sequence
    - maximum compatible subsequence
- When greedy local choices may fail globally

### 💡 Mental trigger:
“What is the best sequence ending at this position?”
“Which previous states can connect to me?”

---

## 🔗 Similar Questions
- [Increasing Triplet Subsequence](https://leetcode.com/problems/increasing-triplet-subsequence/)
- [Russian Doll Envelopes](https://leetcode.com/problems/russian-doll-envelopes/)
- [Maximum Length of Pair Chain](https://leetcode.com/problems/maximum-length-of-pair-chain/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2