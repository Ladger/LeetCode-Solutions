## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- String Matching
- KMP Algorithm

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Instead of restarting pattern from at the start of the pattern, 
we should reuse the previously matched prefix by using LPS (Longest Proper Suffix) array

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I was made my first solution as naive approach that try to match at the beginning for every non-matching scenerios
It was bad since it leads the time complexity to O(mn)

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I learnt we can use algorithm called KMP algorithm that saves the previous matched prefixes,
that way the solution becomes in linear time O(m + n)

---

## ⏱️ Complexity
- **Time:** O(m + n)
- **Space:** O(m)

---

## 🧠 When to Use This Pattern
- When asked substring in the string
- When brute force causes repeated comparisons

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2
- [ ] Can solve without help