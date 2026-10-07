namespace Tests;

public class PrintOrderTest
{
    [Fact]
    public void Example1()
    {
        var print = new PrintOrder();
        int[] priorities = { 2, 1, 3, 2 };

        int result = print.printOrder(priorities, 2);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Example2()
    {
        var printer = new PrintOrder();
        int[] priorities = { 1, 1, 9, 1, 1, 1 };

        int result = printer.printOrder(priorities, 0);

        Assert.Equal(5, result);
    }

    [Fact]
    public void EqualPrioritesEdgeCase()
    {
        var printer = new PrintOrder();
        int[] priorities = { 3, 3, 3 };

        int result = printer.printOrder(priorities, 2);

        Assert.Equal(3, result);
    }
}