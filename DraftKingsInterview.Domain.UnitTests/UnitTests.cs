using DraftKingsInterview.Domain.Enums;
using DrattKingsInterview.Domain.Helpers;
using NUnit.Framework;

namespace DraftKingsInterview.Domain.UnitTests
{
    public class UnitTests
    {
        private ReverseEngineering.Class1 oldDiscountCalculator;

        [SetUp]
        public void Setup()
        {
            oldDiscountCalculator = new ReverseEngineering.Class1();
        }

        [Test]
        public void GivenFreeUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.FreeUser, accountAgeInYears: 3);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 1, years: 3);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPremiumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.PremiumUser, accountAgeInYears: 3);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 2, years: 3);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenUltraPremiumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.UltraPremiumUser, accountAgeInYears: 3);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 3, years: 3);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPlatinumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.PlatinumUser, accountAgeInYears: 3);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 4, years: 3);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenFreeUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.FreeUser, accountAgeInYears: 10);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 1, years: 10);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPremiumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.PremiumUser, accountAgeInYears: 10);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 2, years: 10);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenUltraPremiumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.UltraPremiumUser, accountAgeInYears: 10);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 3, years: 10);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPlatinumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, CustomerType.PlatinumUser, accountAgeInYears: 10);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, 4, years: 10);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }
    }
}