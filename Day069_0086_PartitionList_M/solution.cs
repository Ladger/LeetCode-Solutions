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
    public ListNode Partition(ListNode head, int x) {
        if (head == null) return head;

        ListNode smallDummy = new ListNode(0);
        ListNode largeDummy = new ListNode(0);

        ListNode small = smallDummy;
        ListNode large = largeDummy;

        ListNode curr = head;
        while (curr != null) {
            if (curr.val < x) {
                small.next = curr;
                small = small.next;
            }
            else {
                large.next = curr;
                large = large.next;
            }

            curr = curr.next;
        }

        if (smallDummy.next == null) return largeDummy.next;
        else if (largeDummy.next == null) return smallDummy.next;

        large.next = null;
        small.next = largeDummy.next;

        return smallDummy.next;
    }
}