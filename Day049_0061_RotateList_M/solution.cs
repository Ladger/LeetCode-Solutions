public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0)
            return head;

        ListNode tail = head;
        int length = 1;
        while (tail.next != null) {
            tail = tail.next;
            length++;
        }

        k %= length;
        if (k == 0) return head;

        tail.next = head;
        tail = tail.next;

        int newTailSteps = length - k - 1;
        for (int i = 0; i < newTailSteps; i++) {
            tail = tail.next;
        }

        head = tail.next;
        tail.next = null;

        return head;
    }
}