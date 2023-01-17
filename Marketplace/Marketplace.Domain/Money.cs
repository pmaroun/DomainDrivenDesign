using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public record Money
    {
        public decimal Amount { get; init; }

        public Money(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Amount must be greater than 0");

            this.Amount = amount;
        }

        public Money Add(Money summand) => new Money(Amount + summand.Amount);
        public Money Substract(Money subtrahend) => new Money(Amount - subtrahend.Amount);

        public static Money operator +(Money summand1, Money summand2) => summand1.Add(summand2);
        public static Money operator -(Money subtrahend1, Money subtrahend2) => subtrahend1.Substract(subtrahend2);

    }
}
