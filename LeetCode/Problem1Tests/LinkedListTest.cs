using System.Reflection;


namespace Tests;

public class LinkedListTest
{
    static LinkedList Initialize(params int[] values)
    {
        var list = new LinkedList();

        foreach (int value in values)
        {
            list.Append(value);
        }

        return list;
    }

    [Fact]
    public void FirstExample()
    {
        var list = Initialize(1, 2, 3, 4, 5, 6, 7, 8, 9);
        list.ReverseAlternateK(3);
        Assert.Equal("3,2,1,4,5,6,9,8,7", list.ToText());
    }

    [Fact]
    public void SecondExample()
    {
        var list = Initialize(1, 2, 3, 4, 5);
        list.ReverseAlternateK(2);
        Assert.Equal("2,1,3,4,5", list.ToText());
    }

    [Fact]
    public void EdgeCaseSingleNode()
    {
        var list = new LinkedList();
        list.Append(5);
        list.ReverseAlternateK(3);
        Assert.Equal("5", list.ToText());
    }
}
