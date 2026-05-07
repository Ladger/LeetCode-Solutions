# 🧠 Problem: Happy Number

- **Link:** [LeetCode 202 - Happy Number](https://leetcode.com/problems/happy-number/)

## 🧩 Pattern / Topic
- **Two Pointers (Floyd's Cycle-Finding Algorithm)**
- **HashSet**

---

## 💡 Key Idea
- A "Happy Number" is defined by a process where you replace the number with the sum of the squares of its digits. If this process ends in 1, it's happy; if it enters an infinite loop that doesn't include 1, it's not.
- The core insight is that since the sum of squares of digits of any number eventually stays within a predictable range, we are guaranteed to either hit **1** or enter a **cycle**.

---

## ❌ Mistakes / Struggles
- **Infinite Loops:** Forgetting to handle the case where the sequence repeats, leading to a `Time Limit Exceeded` error.
- **Hard-coding the Cycle:** Some try to hard-code the specific non-happy cycle (starting with 4), but this is less generalizable than cycle detection algorithms.

---

## 🔁 Better / Optimal Solution
- **Floyd's Cycle-Finding Algorithm (Tortoise and Hare):** Instead of using extra space (HashSet), use two pointers. The `slow` pointer moves one step (calculates next sum once), and the `fast` pointer moves two steps (calculates next sum of next sum). If they meet at 1, the number is happy. If they meet at any other number, a cycle exists.
- This is optimal because it reduces space complexity from $O(N)$ to $O(1)$.

---

## ⏱️ Complexity
- **Time:** O(logn)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Use **Cycle Detection** whenever you are repeatedly transforming a value and need to determine if the sequence will eventually reach a specific target or repeat itself endlessly.

### 💡 Mental trigger:
"Does this sequence loop?" **Floyd’s Tortoise and Hare.**

---

## 🔗 Similar Questions
- [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/)
- [Find the Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2