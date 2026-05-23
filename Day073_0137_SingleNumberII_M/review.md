# 🧠 Problem: 137. Single Number II

- **Link:** [Problem Link](https://leetcode.com/problems/single-number-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Bit Manipulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Every number appears 3 times except one.
- Instead of counting explicitly, track bit occurrences using two bitmasks:
  - ones → bits seen 1 time
  - twos → bits seen 2 times
- Each bit cycles through a 3-state FSM: 00 → 01 → 10 → 00
- After 3 occurrences, bits reset to 0 automatically.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Trying to treat ones and twos as simple counters instead of bitwise states per bit position
- Confusion about update order in bit operations
- Thinking “just store occurrences per number” instead of per bit

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use two bitmasks:
  - Update “twos” when a bit appears again in “ones”
  - Toggle “ones” with XOR
  - Remove bits that appear 3 times from both masks

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When numbers appear in fixed repetition patterns (like 3x, 5x)
- When you suspect XOR alone is not enough
- When constraints suggest O(1) extra space but counting is needed

### 💡 Mental trigger:
“Repeated elements with fixed frequency → try bitwise FSM instead of hashmap”

---

## 🔗 Similar Questions
- [Single Number](https://leetcode.com/problems/single-number/)
- [Single Number III](https://leetcode.com/problems/single-number-iii/)
- [Find the XOR of Numbers Which Appear Twice](https://leetcode.com/problems/find-the-xor-of-numbers-which-appear-twice/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2