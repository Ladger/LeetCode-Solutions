# 🧠 Problem: 141. Linked List Cycle

- **Link:** [Problem Link](https://leetcode.com/problems/linked-list-cycle/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Hash Table
- Linked List
- Two Pointers

---

## 💡 Key Idea
- If a cycle exists in a linked list, a "fast" pointer moving two nodes at a time will eventually lap and collide with a "slow" pointer moving one node at a time. 
- If the fast pointer reaches the end (`null`), there is no cycle.

---

## ❌ Mistakes / Struggles
- Using a `List<ListNode>` and checking `values.Contains(head)` is a major C# performance trap. `List.Contains()` operates in **O(N)** time because it linearly searches the array under the hood. 
- Placing this inside an **O(N)** `while` loop makes the overall time complexity **O(N²)**.
- Even if a `HashSet<ListNode>` was used to fix the lookup time to O(1), storing every visited node still costs **O(N)** auxiliary space, which fails the strict O(1) memory constraint often expected in interviews.

---

## 🔁 Better / Optimal Solution
- **Floyd’s Cycle-Finding Algorithm (Tortoise and Hare):** This completely eliminates the need for extra data structures. 
- By using just two reference pointers (`fast` and `head` as the slow pointer), 
- We achieve the optimal time complexity while dropping the space complexity to true O(1). 

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Any time we need to detect loops or cyclic dependencies in a sequence.
- When traversing linked lists to find midpoints (the slow pointer will be at the middle when the fast pointer hits the end).
- When a problem demands O(1) space constraints for list or array traversals.

---

## 🔗 Similar Questions
- [142. Linked List Cycle II](https://leetcode.com/problems/linked-list-cycle-ii/)
- [202. Happy Number](https://leetcode.com/problems/happy-number/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2