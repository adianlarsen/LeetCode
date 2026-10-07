//Problem 4
// I use the array to represent a queue of jobs. I go through and check if the front job has less priority than any of the others, and if it does, I move it to the back of the array. If there isn't, I print the value.
// The method ends when the job at location is printed and its number is returned.
// The time complexity is O(n^2) because a job can be sent to the back of the array multiple times. The space complexity is O(n) because of the queue array.

public class PrintOrder
{
    public int printOrder(int[] priorities, int location)
    {
        int n = priorities.Length;
        int[] counts = new int[10];
        int[] queue = new int[n];
        int head = 0;
        int size = n;

        for (int i = 0; i < n; i++)
        {
            queue[i] = i;
            counts[priorities[i]]++;
        }

        int printedValue = 0;

        while (size > 0)
        {
            int job = queue[head];
            head = (head + 1) % n;
            size--;

            bool higherWaiting = false;
            for (int p = priorities[job] + 1; p <= 9; p++)
            {
                if (counts[p] > 0)
                {
                    higherWaiting = true;
                    break;
                }
            }

            if (higherWaiting)
            {
                int tail = (head + size) % n;
                queue[tail] = job;
                size++;
            }
            else
            {
                printedValue++;
                counts[priorities[job]]--;
                if (job == location)
                {
                    return printedValue;
                }
            }
        }

        return -1;
    }
}