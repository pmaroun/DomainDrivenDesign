namespace Marketplace.Domain;

public record Money
{
    public Money(decimal amount)
    {
        if (amount < 0) throw new ArgumentException("Amount must be greater than 0");

        Amount = amount;
    }

    public decimal Amount { get; init; }

    public Money Add(Money summand)
    {
        return new(Amount + summand.Amount);
    }

    public Money Substract(Money subtrahend)
    {
        return new(Amount - subtrahend.Amount);
    }

    public static Money operator +(Money summand1, Money summand2)
    {
        return summand1.Add(summand2);
    }

    public static Money operator -(Money subtrahend1, Money subtrahend2)
    {
        return subtrahend1.Substract(subtrahend2);
    }
}