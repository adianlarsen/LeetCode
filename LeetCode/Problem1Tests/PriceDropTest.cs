namespace Tests;

public class PriceDropTest
{
    [Fact]
    public void Example1()
    {
        var priceTracker = new PriceDropTracker();
        int[] prices = { 8, 4, 6, 2, 3 };

        int[] result = priceTracker.daysUntilDrop(prices);

        Assert.Equal(new int[] { 1, 2, 1, -1, -1 }, result);
    }

    [Fact]
    public void Example2()
    {
        var priceTracker = new PriceDropTracker();
        int[] prices = { 1, 2, 3, 4 };

        int[] result = priceTracker.daysUntilDrop(prices);

        Assert.Equal(new int[] { -1, -1, -1, -1 }, result);
    }

    [Fact]
    public void EqualPricesDontCOunt()
    {
        var priceTracker = new PriceDropTracker();
        int[] prices = { 3, 3 };

        int[] result = priceTracker.daysUntilDrop(prices);

        Assert.Equal(new int[] { -1, -1 }, result);
    }
}