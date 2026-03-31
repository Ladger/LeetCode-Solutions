# 🧠 Problem: 205. Isomorphic Strings

- **Link:** [Problem Link](https://leetcode.com/problems/isomorphic-strings/description/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Hashmap/Dictionary
- Character Mapping

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Two strings are isomorphic if there exists a one-to-one mapping between the characters of s and t such that the characters in s can be replaced to get t.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Actually the hardest part was understanding the two one-directional mapping, quite a long time I thought it was bi-directional mapping. 
Therefore I could not pass the test cases.
- I think Leetcode explanation might little lacking to explain this one-directional mapping, I understood that by checking the discussion.
- My first approach was correct but it was not the best *(solution_dict.cs)*. I used 2 dictionaries and checked the maps using ContainsKey, 
it is not the brightest solution but at the and it uses O(n) time and O(1) space complexity since we are dealing with ASCII characters

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I learnt this method in later days of my Leetcode challange, since all the alphabet from ASCII character we can use them in integer arrays as frequency arrays.
- We are creating two mapping arrays with size 128 (since ASCII), and looping the strings from the start. Therefore all we need to do checking are they saved to map; if they are, are they equal?
- It is similar to my original solution, however it has less lookups and better if-else blocks
- It is O(n) time complexity since it is looping once, and O(1) space complexity because we are working with 128 sized arrays. If alphabet goes further space complexity will become O(n).

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When checking one-to-one correspondence between two sequences.
- Counting occurrences / histograms (frequency arrays).
- Sorting by frequency / bucket sort

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2