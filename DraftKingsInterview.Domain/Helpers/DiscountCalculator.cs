using DraftKingsInterview.Domain.Enums;
using System.Collections.Generic;

namespace DrattKingsInterview.Domain.Helpers
{      
    public class DiscountCalculator
    {
        private const decimal MaxDiscountPercentageBasedOnAccountAge = 5m / 100;
        private const int AccountAgeInYearsDiscountLimiter = 5;
        private static readonly IDictionary<CustomerType, decimal> customerTypeToDiscountPercentageMap = new Dictionary<CustomerType, decimal>
        {
            { CustomerType.FreeUser, 0m },
            { CustomerType.PremiumUser, 10m / 100 },
            { CustomerType.UltraPremiumUser, 30m / 100 },
            { CustomerType.PlatinumUser, 50m / 100 }
        };

        /// <summary>
        /// Calculates the final discounted amount based on the type of the user and the user's account age
        /// </summary>
        /// <param name="originalAmount"></param>
        /// <param name="customerType"></param>
        /// <param name="accountAgeInYears"></param>
        /// <returns>The final discounted amount</returns>
        public static decimal CalculateDiscountedAmount(decimal originalAmount, CustomerType customerType, int accountAgeInYears)
        {
            // some parameter validation may be good here, but it probably would already have been done at this point in the real world

            var finalDiscountedAmount = originalAmount;
            var discountPercentageBasedOnAccountAge = 0m;

            if (customerType != CustomerType.FreeUser)
            {
                discountPercentageBasedOnAccountAge = accountAgeInYears > AccountAgeInYearsDiscountLimiter ? MaxDiscountPercentageBasedOnAccountAge : accountAgeInYears / 100m;
            }

            var discountPercentageBasedOnCustomerType = customerTypeToDiscountPercentageMap.ContainsKey(customerType) ? customerTypeToDiscountPercentageMap[customerType] : 0m;
            var discountedAmountBasedOnCustomerType = originalAmount * (1.0m - discountPercentageBasedOnCustomerType);
            finalDiscountedAmount = discountedAmountBasedOnCustomerType * (1.0m - discountPercentageBasedOnAccountAge);

            return finalDiscountedAmount;
        }
    }
}
