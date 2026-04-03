# 🧠 Problem: 228. Summary Ranges

- **Link:** [Problem Link](https://leetcode.com/problems/summary-ranges/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Intervals

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- We should keep two pointers one is for indication start other is the end of the interval. End should increase as numbers are concecutive
- If they are not we should execute our add to the string format and reset the start and end for the current position on the list.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I did not feel any struggle, however I am not happy with the code structure neither.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- We can actually determine the intervals with one pass.
- We are keeping two index values: start and end. They will help us to detect concecutive numbers.
- In each iteration, we are increasing end index at the end of the loop. 
- Therefore on the next iteration we can see if previous value is concecutive to the current number.
- If not concecutive we are adjusting the indices to the new non-concecutive number.

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(N)

---

## 🧠 When to Use This Pattern
- When you need to group consecutive elements into ranges or segments
- When you need to detect boundaries where a condition breaks
- When you can expand a window until a rule fails, then finalize and restart

---

## 🔗 Similar Questions
- [352. Data Stream as Disjoint Intervals](https://leetcode.com/problems/data-stream-as-disjoint-intervals/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2