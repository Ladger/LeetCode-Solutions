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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (left == right) return head;

        ListNode curr = head;
        ListNode prev = null;
        
        ListNode bln;
        ListNode ln;

        int i = 1;
        while (curr != null) {
            
            if (i == left) {
                bln = prev;
                ln = curr;

                for (int j = 0; j < right - left + 1; j++) {
                    ListNode next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }
                
                if (bln != null)
                    bln.next = prev;
                else
                    head = prev;

                ln.next = curr;
                break;
            }
            else {
                prev = curr;
                curr = curr.next;
                i++;
            }
        }

        return head;
    }
}