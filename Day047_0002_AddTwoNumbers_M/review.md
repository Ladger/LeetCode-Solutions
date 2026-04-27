# 🧠 Problem: 3. Add Two Numbers

- **Link:** [Problem Link](https://leetcode.com/problems/add-two-numbers/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Math
- Recursion

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Traverse both linked lists simultaneously and simulate elementary addition digit by digit.
- Maintain a carry value just like manual addition.
- Create a new linked list as you compute each digit (sum % 10) and propagate carry (sum / 10)

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Forgetting to handle the final carry (e.g., 5 + 5 → need extra node).
- Overcomplicating by trying to convert the list into an integer (breaks for large inputs).
- Not using a dummy head, which makes edge cases messy.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a dummy node to simplify list construction.
- Loop while:
    - l1 != null || l2 != null || carry != 0
- Extract values safely:
    - val1 = l1 != null ? l1.val : 0
    - val2 = l2 != null ? l2.val : 0
- Compute:
    - sum = val1 + val2 + carry
    - digit = sum % 10
    - carry = sum / 10
- Append new node and move pointers.

---

## ⏱️ Complexity
- **Time:** O(m + n)
- **Space:** O(m + n)

---

## 🧠 When to Use This Pattern
- When dealing with:
    - Numbers stored digit-by-digit
    - Linked list arithmetic
    - Problems involving carry/borrow propagation
- Keywords:
    - “digit”, “reverse order”, “add numbers”, “linked list representation”

---

## 🔗 Similar Questions
- [43. Multiply Strings](https://leetcode.com/problems/multiply-strings/)
- [371. Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/)
- [445. Add Two Numbers II](https://leetcode.com/problems/add-two-numbers-ii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2