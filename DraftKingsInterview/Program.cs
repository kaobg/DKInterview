using DrattKingsInterview.Domain.Helpers;
using System;

namespace DrattKingsInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var discountedAmount = DiscountCalculator.CalculateDiscountedAmount(
                originalAmount: 10, 
                DraftKingsInterview.Domain.Enums.CustomerType.FreeUser, 
                accountAgeInYears: 5);

            Console.WriteLine(discountedAmount);
        }
    }
}
