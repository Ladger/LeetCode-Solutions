# 🧠 Problem: 49. Group Anagrams

- **Link:** [Problem Link](https://leetcode.com/problems/group-anagrams/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Hash Table
- String

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The goal is to group words that are anagrams of each other. 
- Anagrams share the same characters with the same frequencies, 
- So if you sort the characters of each word or create a character count frequency array, every word in the same anagram group will produce the exact same "key."

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- No major struggle for this question, however I had used ContainsKey instead of TryGetValue (unnecessary lookup).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Initialize a HashMap where the key is a unique representation of character counts.
- For each string, count the occurrences of each letter (a-z).
- Use that count array (converted to a tuple) as the key.
- Append the original string to the list corresponding to that key.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- Use Hash Table Categorization when you need to group items based on a shared property.
- Use it when a "signature" (like a sorted string or frequency count) can uniquely identify a group.
- Useful in frequency-based problems or when order of elements within a specific item doesn't matter.

---

## 🔗 Similar Questions
- [242. Valid Anagram](https://leetcode.com/problems/valid-anagram/)
- [2273. Find Resultant Array After Removing Anagrams](https://leetcode.com/problems/find-resultant-array-after-removing-anagrams/)
- [2514. Count Anagrams](https://leetcode.com/problems/count-anagrams/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2