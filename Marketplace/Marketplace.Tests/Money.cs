using Marketplace.Domain;

namespace Marketplace.Tests;

public class MoneyTests
{
    [Fact]
    public void Money_objects_with_the_same_amount_should_be_equal()
    {
        var firstAmount = new Money(123);
        var secondAmount = new Money(123);

        Assert.Equal(firstAmount, secondAmount);
    }

    [Fact]
    public void Money_objects_can_be_added()
    {
        var firstAmount = new Money(123);
        var secondAmount = new Money(123);

        var sum = firstAmount.Add(secondAmount);
        Assert.Equal(sum.Amount, 246);
    }

    [Fact]
    public void Money_objects_can_be_subtracted()
    {
        var firstAmount = new Money(123);
        var secondAmount = new Money(123);

        var sum = firstAmount.Substract(secondAmount);
        Assert.Equal(sum.Amount, 0);
    }

    [Fact]
    public void Money_objects_can_be_subtracted_with_operation()
    {
        var firstAmount = new Money(123);
        var secondAmount = new Money(123);

        var sum = firstAmount - secondAmount;
        Assert.Equal(sum.Amount, 0);
    }
}