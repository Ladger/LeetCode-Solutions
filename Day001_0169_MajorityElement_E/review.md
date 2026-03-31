# 🧠 Problem: 169. Majority Element

- **Link:** [Problem Link](https://leetcode.com/problems/majority-element/description/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Counting

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Since we know one of the elements is occuring more than half of length of the array,
So we are pairing off the elements by counting. 
We know our majority element will survive because of the number of occurances.
It is known as Boyer-Moore Voting Algorithm

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- First approach i tried was dictionary method, however it contains key search in loops it works inefficiently. Also it is inefficient for the space complexity also
- Second try was a bit smarter, I sorted the nums array. 
That way I can know the middle element will always be the majority element even it is the smallest or larger value. 
Time complexity for this method O(nlogn) for any sorting algorithm works with "nlogn"

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The best solution for this problem was Boyer-Moore Voting approach, it is highly efficient for both time and space, since we are using just two variables and one-pass for these variables.
The algorithm pass over the list and eliminates the non-major elements by simple counting

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Element appears mor than n/2 times
- Finding dominant elements

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2