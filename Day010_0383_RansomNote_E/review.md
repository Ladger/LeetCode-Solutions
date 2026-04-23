# 🧠 Problem: 383. Ransom Note

- **Link:** [Problem Link](https://leetcode.com/problems/ransom-note/)

## 🧩 Pattern / Topic
- Counting
- Hash Map / Dictionary
- String

---

## 💡 Key Idea
- The core insight is to tally up the available "resources" (characters in the magazine) and then verify if we have enough to "pay" for the requirements (characters in the ransom note). 
- If at any point the ransom note requires a letter we don't have or requires more copies of it than we possess, we immediately know it's impossible.

---

## ❌ Mistakes / Struggles
- Defaulting to a `Dictionary` (Hash Map) when it isn't strictly necessary. 
- While a Dictionary works perfectly, it introduces hashing overhead and consumes more memory than needed when dealing with a restricted, predictable character set.
- I do not know why but I resisted learning frequency count solutions like this kind of questions quite a while.

---

## 🔁 Better / Optimal Solution
- I learned that for problems strictly limited to lowercase English letters, a fixed-size integer array (`int[26]`) is the most optimal "Hash Map" you can use. 
- By mapping characters to array indices using simple ASCII math (`c - 'a'`), you get blazing fast O(1) access times with practically zero memory overhead compared to a full Dictionary. 
- It's a fantastic micro-optimization pattern for string problems.

---

## ⏱️ Complexity
- **Time:** O(M + N) — (M: length of magazine, N: ransom note)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Whenever you need to verify if one string can be constructed from the characters of another (subset checking).
- When solving Anagram problems or problems that require comparing character frequencies.
- **Crucial trigger:** Whenever you see "consists of only lowercase English letters," immediately consider using a fixed-size `int[26]` array instead of a Hash Map to count frequencies.

---

## 🔗 Similar Questions
- [242. Valid Anagram](https://leetcode.com/problems/valid-anagram/)
- [438. Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/)
- [567. Permutation in String](https://leetcode.com/problems/permutation-in-string/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2