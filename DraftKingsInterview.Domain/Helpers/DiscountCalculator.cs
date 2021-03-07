using DraftKingsInterview.Domain.Enums;
using System.Collections.Generic;

namespace DrattKingsInterview.Domain.Helpers
{      
    public class DiscountCalculator
    {
        private const decimal MaxDiscountPercentageBasedOnAccountAge = 5m / 100;
        private const int AccountAgeInYearsLimitForDiscount = 5;
        private static readonly IDictionary<CustomerType, decimal> customerTypeToDiscountRatioMap = new Dictionary<CustomerType, decimal>
        {
            { CustomerType.FreeUser, 1.0m },
            { CustomerType.PremiumUser, 0.9m },
            { CustomerType.UltraPremiumUser, 0.7m },
            { CustomerType.PlatinumUser, 0.5m }
        };

        public static decimal CalculateDiscountedAmount(decimal originalAmount, CustomerType customerType, int accountAgeInYears)
        {
            // some parameter validation may be good here, but it probably would already have been done at this point in the real world

            var finalDiscountedAmount = originalAmount;
            var discountPercentageBasedOnAccountAge = 0m;

            if (customerType != CustomerType.FreeUser)
            {
                discountPercentageBasedOnAccountAge = accountAgeInYears > AccountAgeInYearsLimitForDiscount ? MaxDiscountPercentageBasedOnAccountAge : accountAgeInYears / 100m;
            }

            var discountRatioBasedOnCustomerType = customerTypeToDiscountRatioMap.ContainsKey(customerType) ? customerTypeToDiscountRatioMap[customerType] : 1.0m;
            var discountedAmountBasedOnCustomerType = discountRatioBasedOnCustomerType * originalAmount;
            finalDiscountedAmount = discountedAmountBasedOnCustomerType 
                - discountPercentageBasedOnAccountAge * discountedAmountBasedOnCustomerType;

            return finalDiscountedAmount;
        }
    }
}
