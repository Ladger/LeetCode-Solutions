# 🧠 Problem: 66. Plus One

- **Link:** [Problem Link](https://leetcode.com/problems/plus-one/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Math

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Start from the least significant digit (rightmost).
- If the digit is less than 9, increment it and return immediately.
- If the digit is 9, it becomes 0 and the carry propagates to the next digit.
- If every digit is 9, create a new array with a leading 1.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Converting the digit array into an integer can cause overflow.
- Using Math.Pow introduces unnecessary work and can create precision issues for very large numbers.
- Forgetting that the input may represent a number larger than any built-in numeric type.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Treat the array exactly as you would perform addition by hand.
- Process digits from right to left.
- Return immediately when no carry remains.
- Only allocate a new array when all digits are 9.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When a number is represented as an array of digits.
- When performing arithmetic operations that may exceed built-in numeric types.
- When carry/borrow propagation is involved.

### 💡 Mental trigger:
"The input is given as digits instead of a number."

---

## 🔗 Similar Questions
- [Multiply Strings](https://leetcode.com/problems/multiply-strings/)
- [Add Binary](https://leetcode.com/problems/add-binary/)
- [Add to Array-Form of Integer](https://leetcode.com/problems/add-to-array-form-of-integer/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2