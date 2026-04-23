# 🧠 Problem: 67. Add Binary

- **Link:** [Problem Link](https://leetcode.com/problems/add-binary/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Math
- String
- Bit Manipulation

---

## 💡 Key Idea
- The core insight is to simulate standard "schoolbook" column addition, starting from the rightmost digits (least significant bits). 
- For each column, you add the corresponding bits from both strings along with any carry-over from the previous column. 
- The current bit is the sum modulo 2 (`sum % 2`), and the new carry is the sum divided by 2 (`sum / 2`).

---

## ❌ Mistakes / Struggles
- My initial approach involved converting the strings into character arrays and reversing them upfront so I could easily loop from left to right. 
- However, I learned that this costs extra time and memory allocations. 
- **Integer overflow:** One of the issues I faced was trying to convert the binary strings directly to integers (e.g., using `Convert.ToInt32`), adding them, and converting back. This immediately breaks and throws overflow exceptions for large binary strings that exceed standard integer limits.
- **Char-to-Int conversion:** In my first attempt, I could not think of the `c[i] - '0'` approach. Realizing you can subtract the ASCII value of '0' to safely get the actual integer bit makes the problem much easier and avoids complex parsing.

---

## 🔁 Better / Optimal Solution
- The current, optimal solution skips those initial array conversions entirely. 
- By using two pointers starting at the very end of the original strings (`a.Length - 1` and `b.Length - 1`), 
- We can process the digits backwards directly into a result list, and then reverse the final result just once at the end.

---

## ⏱️ Complexity
- **Time:** O(max(N, M)) 
- **Space:** O(max(N, M))

*Where N is the length of string `a` and M is the length of string `b`.*

---

## 🧠 When to Use This Pattern
- Whenever you need to perform arithmetic (addition, multiplication) on arbitrarily large numbers represented as strings or arrays (often called BigInt problems).
- When you need to process sequences element-by-element while maintaining a state (like a carry or borrow) between iterations.

---

## 🔗 Similar Questions
- [415. Add Strings](https://leetcode.com/problems/add-strings/)
- [2. Add Two Numbers](https://leetcode.com/problems/add-two-numbers/)
- [989. Add to Array-Form of Integer](https://leetcode.com/problems/add-to-array-form-of-integer/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2