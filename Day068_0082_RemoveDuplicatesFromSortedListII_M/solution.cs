/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null) return head;

        ListNode curr = head;
        ListNode dummy = new ListNode(-1, curr);
        ListNode prev = dummy;

        while (curr != null) {
            if (curr.next != null && curr.val == curr.next.val) {
                int val = curr.val;
                while (curr != null && curr.val == val) {
                    curr = curr.next;
                    prev.next = curr;
                }

                if (head.val == val) head = curr;
            } 
            else {    
                prev = curr;
                curr = curr.next;
            }
        }

        return head;
    }
}