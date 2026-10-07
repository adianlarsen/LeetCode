//Problem 3
//I walk the array from left to right and find on the stack where a next lower price hasn't been found. When I find that today's price is lower than the top, I pop it. Because I walk the list and visit each index once, the time complexity is O(n) and the space is also O(n)
public class PriceDropTracker
{
    public int[] daysUntilDrop(int[] prices)
    {
        int n = prices.Length;
        int[] answer = new int[n];
        for (int k = 0; k < n; k++)
        {
            answer[k] = -1;
        }

        Stack<int> stack = new();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[i] < prices[stack.Peek()])
            {
                int j = stack.Pop();
                answer[j] = i - j;
            }
            stack.Push(i);
        }
        return answer;
    }
}
