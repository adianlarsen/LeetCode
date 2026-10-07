using System;

public class Node
{
    public int value;
    public Node? next;

    public Node(int value)
    {
        this.value = value;
    }
}

public class LinkedList
{
    private Node? head;

    public void Append(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null) temp = temp.next;
        temp.next = newNode;
    }

    public string ToText()
    {
        var parts = new List<int>();
        for (Node? t = head; t != null; t = t.next) parts.Add(t.value);
        return string.Join(",", parts);
    }

    // I reverse the nodes of every other group of k nodes. The way I achieved this was using a dummy node and previousTail to flip and then reconnect the list. I only go to every node once, so the time complexity is O(n) and the space complexity is O(1).
    public void ReverseAlternateK(int k)
    {
        if (head == null || k <= 1)
        {
            return;
        }

        Node dummy = new Node(0);
        dummy.next = head;
        Node previousTail = dummy;
        bool reverseTurn = true;

        while (previousTail.next != null)
        {
            if (reverseTurn)
            {
                Node startOfGroup = previousTail.next;
                Node? previous = null;
                Node? current = startOfGroup;
                int count = 0;

                while (current != null && count < k)
                {
                    Node? next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                    count++;
                }

                previousTail.next = previous;
                startOfGroup.next = current;
                previousTail = startOfGroup;
            }
            else
            {
                for (int i = 0; i < k && previousTail.next != null; i++)
                {
                    previousTail = previousTail.next;
                }
            }
            reverseTurn = !reverseTurn;
        }
        head = dummy.next;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
    }
}
