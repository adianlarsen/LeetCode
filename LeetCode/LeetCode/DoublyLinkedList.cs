public class DoubleNode
{
    public int value;
    public DoubleNode next;
    public DoubleNode prev;

    public DoubleNode(int value)
    {
        this.value = value;
    }
}

public class DoublyLinkedList
{
    private DoubleNode head;
    private DoubleNode tail;
    private int length;

    public DoublyLinkedList(int value)
    {
        DoubleNode newNode = new DoubleNode(value);
        head = newNode;
        tail = newNode;
        length = 1;
    }

    public void Append(int value)
    {
        DoubleNode newNode = new DoubleNode(value);
        if (length == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        length++;
    }

    public string ToText()
    {
        var parts = new List<int>();
        for (DoubleNode temp = head; temp != null; temp = temp.next) parts.Add(temp.value);
        return string.Join(",", parts);
    }

    public string ToTextBackward()
    {
        var parts = new List<int>();
        for (DoubleNode temp = tail; temp != null; temp = temp.prev) parts.Add(temp.value);
        return string.Join(",", parts);
    }

    // For efficiency, I take the mod of k first, I then walk back from the tail and find the new head which on the k node from the end. I then split and then link the new lists. As I am just walking the list, the time complexity is O(n) and the space complexity is O(1).
    public void Rotate(int k)
    {
        if (head == null)
        {
            return;
        }

        k = k % length;

        if (k == 0)
        {
            return;
        }

        DoubleNode newHead = tail;

        for (int i = 0; i < k - 1; i++)
        {
            newHead = newHead.prev;
        }

        DoubleNode newTail = newHead.prev;

        tail.next = head;
        head.prev = tail;

        newTail.next = null;
        newHead.prev = null;

        head = newHead;
        tail = newTail;
    }
}