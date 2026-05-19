# 🧠 Problem: 86. Partition List

- **Link:** [Problem Link](https://leetcode.com/problems/partition-list/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Two Pointers

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Instead of rearranging nodes inside the same linked list, create two separate linked lists:
  - one for nodes smaller than `x`
  - one for nodes greater than or equal to `x`
- Preserve relative order while traversing once, then connect the two lists at the end.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried modifying the original list in-place while iterating.
- Pointer updates (`prev`, `curr`, `last`) became difficult to track.
- Accidentally created cycles because original `next` connections were still preserved.
- Forgot to terminate the larger list with: large.next = null;

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Using dummy nodes simplifies linked list construction.
- Separating nodes into two independent chains avoids complex insertion logic.
- Always be careful about old next references when reusing existing nodes.
- Final structure: small list + large list

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When a linked list problem asks to:
    - reorder nodes while preserving relative order
    - split nodes into groups/categories
    - avoid expensive in-place insertions
- Very useful when node movement becomes messy with many edge cases.

### 💡 Mental trigger:
"Can I build multiple linked lists first and merge later instead of modifying the same list in-place?"

---

## 🔗 Similar Questions
- [Partition Array According to Given Pivot](https://leetcode.com/problems/partition-array-according-to-given-pivot/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2