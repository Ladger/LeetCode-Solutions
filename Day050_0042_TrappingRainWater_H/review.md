# 🧠 Problem: 42. Trapping Rain Water

- **Link:** [Problem Link](https://leetcode.com/problems/trapping-rain-water/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Two Pointers
- Dynammic Programming
- Stack

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- We need to have left and right global maximums for every point.
- We can either calculate it from the start or dynammicaly.
- For a dynammic approach, we should use two pointers.
- However, we do not need global maximum for each side, we just need the smaller global maximum side.
- Therefore, moving the global maximums one for left one for right based on which is smaller is a correct idea for this question.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At the first sight, the problem looked to me very easy. Maybe I underestimated the question.
- Therefore, I realized just the local maximum boundries won't work. (i-1 and i+1 boundaries).
- I easily find the formula of `min(leftMax, rightMax) - height(current)`, however updating leftMax and rightMax was difficult to me.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
### Dynammic Programming Solution
- Create leftMax and rightMax array.
- Traverse the height array at the start for calculating leftMax for each point, `leftMax[i] = Math.Max(leftMax[i - 1], height[i])`
- Traverse the height array from the end for calculating rightMax for each point, `rightMax[i] = Math.Max(rightMax[i + 1], height[i])`
- Iterate the list and use the `Math.Min(leftMax[i], rightMax[i]) - height[i]` for each point and add the result to the water.

### Two Pointers Solution
- Initialize l, r, leftMax and rightMax variables.
- Iterate while l < r:
    - If leftMax smaller than rightMax:
        1. move the l pointer
        2. update the leftMax: `Math.Max(leftMax, height[l])`
        3. Add to the water: `water += leftMax - height[l]`
    - Else:
        1. move the r pointer
        2. update the rightMax: `Math.Max(rightMax, height[r])`
        3. Add to the water: `water += rightMax - height[r]`

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1) - (O(n) for DP solution)

---

## 🧠 When to Use This Pattern
- When a value depends on both left and right constraints
- When “answer at each index” depends on global boundaries
- When preprocessing or greedy boundary tracking can replace full computation
- When a problem can be reframed as:
    - “find limiting factor from both sides”

---

## 🔗 Similar Questions
- [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)
- [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/)
- [Trapping Rain Water II](https://leetcode.com/problems/trapping-rain-water-ii/)
- [Maximum Value of an Ordered Triplet II](https://leetcode.com/problems/maximum-value-of-an-ordered-triplet-ii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2