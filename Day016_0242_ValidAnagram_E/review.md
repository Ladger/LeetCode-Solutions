# 🧠 Problem: 242. Valid Anagram

- **Link:** [Problem Link](https://leetcode.com/problems/valid-anagram/)

## 🧩 Pattern / Topic
- Hash Table
- String
- Counting

---

## 💡 Key Idea
- Anagrams must have the exact same character frequencies. 
- By incrementing a frequency counter for the characters in the first string and decrementing it for the second string simultaneously, 
- All counters will rest exactly at zero if the strings are valid anagrams.

---

## ❌ Mistakes / Struggles
- Overlooking the character set constraints. While sorting both strings and comparing them is an easy conceptual solution, it unnecessarily bumps the time complexity to O(N log N). 
- Additionally, assuming a fixed-size array works for all inputs will cause the solution to break if the problem introduces characters outside the standard 26 lowercase English letters.

---

## 🔁 Better / Optimal Solution
- For a constrained alphabet (like lowercase English letters), a fixed-size array is the most memory-efficient and fastest solution due to its lack of overhead.
- **Handling the Unicode Follow-up:** 
    - To adapt the solution for Unicode characters, substituting the array with a Hash Map (Dictionary) is the optimal move. 
    - A Dictionary safely handles a massive, sparse character set dynamically, rather than attempting to allocate a giant, mostly-empty array for every possible Unicode value.

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(1) - English Letters: 26, Unicode Characters are still finite number so still O(1)

---

## 🧠 When to Use This Pattern
- Whenever you need to verify permutations, check if one string can be constructed from another, or compare the contents of two collections where the exact order of elements does not matter.

---

## 🔗 Similar Questions
- [Group Anagrams](https://leetcode.com/problems/group-anagrams/)
- [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2