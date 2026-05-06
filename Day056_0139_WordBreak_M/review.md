# 🧠 Problem: 139. Word Break

- **Link:** [Problem Link](https://leetcode.com/problems/word-break)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Hash Table
- Trie
- String
- Dynamic Programming
- Memoization

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Define: dp[i] = can we form s[0..i-1]

- For each i, try all j < i:
    - left part must be valid → dp[j]
    - right part must be a word → set.Contains(s[j:i])
    - dp[i] = dp[j] && wordSet.Contains(s.Substring(j, i - j))

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially misunderstood DP size (n vs n+1)
- Forgot why dp[0] = true is necessary (base case for empty string)
- Off-by-one error in loop (i < n instead of i <= n)
- Didn’t fully understand why dp[j] is required (valid prefix guarantee)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use HashSet for O(1) word lookup
- DP builds from smaller prefixes → avoids recomputation
- Break early once a valid split is found

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When a string needs to be split into valid pieces
- When the problem asks:
    - “can we form this string?”
    - “can we segment this sequence?”
- When validity depends on previous segments


- Optional optimization: Limit substring checks using max word length in dictionary (Try it on review)

### 💡 Mental trigger:
“Can I split this into two parts where:
left is already valid, and right is valid by itself?”

---

## 🔗 Similar Questions
- [Word Break II](https://leetcode.com/problems/word-break-ii/)
- [Extra Characters in a String](https://leetcode.com/problems/extra-characters-in-a-string/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2