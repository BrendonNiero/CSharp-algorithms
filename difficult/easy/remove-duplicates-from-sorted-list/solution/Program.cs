public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var cur = head;
        while(cur != null && cur.next != null){
            if(cur.next.val == cur.val){
                cur.next = cur.next.next;
            } else {
                cur = cur.next;
            }
        }
        return head;
    }
}