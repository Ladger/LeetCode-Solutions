/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        List<ListNode> values = new();

        while (head != null) {
            if (values.Contains(head)) return true;
            else values.Add(head);

            head = head.next;
        }

        return false;
    }
}