// Complete the findMergeNode function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode next;
 * }
 *
 */
static int findMergeNode(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
{
    int head1Len = 0, head2Len = 0;
    SinglyLinkedListNode head1copy = head1, head2copy = head2;
    while (head1copy != null)
    {
        head1copy = head1copy.next;
        head1Len++;
    }
    while (head2copy != null)
    {
        head2copy = head2copy.next;
        head2Len++;
    }
    while (head1Len > head2Len)
    {
        head1 = head1.next;
        head1Len--;
    }
    while (head2Len > head1Len)
    {
        head2 = head2.next;
        head1Len--;
    }
    while (head1 != null)
    {
        if (head1 == head2)
        {
            return head1.data;
        }
        head1 = head1.next;
        head2 = head2.next;
    }
    return -1;

}