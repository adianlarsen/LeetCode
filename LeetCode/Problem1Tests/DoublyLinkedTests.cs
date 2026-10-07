namespace Tests;

public class DoublyLinkedTests
{
    static DoublyLinkedList Initialize(params int[] values)
    {
        DoublyLinkedList list = new(values[0]);
        for (int i = 1; i < values.Length; i++)
        {
            list.Append(values[i]);
        }
        return list;
    }
    [Fact]
    public void FirstExample()
    {
        var list = Initialize(1, 2, 3, 4, 5);
        list.Rotate(2);
        Assert.Equal("4,5,1,2,3", list.ToText());
    }

    [Fact]
    public void SecondExample()
    {
        var list = Initialize(1, 2, 3);
        list.Rotate(4);
        Assert.Equal("3,1,2", list.ToText());
    }

    [Fact]
    public void ThirdExample()
    {
        var list = Initialize(7, 8);
        list.Rotate(0);
        Assert.Equal("7,8", list.ToText());
    }

    [Fact]
    public void EdgeCase_HugeK()
    {
        var list = Initialize(1, 2, 3);
        list.Rotate(2000000000);
        Assert.Equal("2,3,1", list.ToText());
    }
}
