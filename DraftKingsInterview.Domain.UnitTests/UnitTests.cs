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
            var yearsSinceAccountCreated = 3;
            var customerType = CustomerType.FreeUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, years: 3);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPremiumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 3;
            var customerType = CustomerType.PremiumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenUltraPremiumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 3;
            var customerType = CustomerType.UltraPremiumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPlatinumUser_AndNewerAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 3;
            var customerType = CustomerType.PlatinumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenFreeUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 10;
            var customerType = CustomerType.FreeUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPremiumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 10;
            var customerType = CustomerType.PlatinumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenUltraPremiumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 10;
            var customerType = CustomerType.UltraPremiumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }

        [Test]
        public void GivenPlatinumUser_AndOlderAccount_WhenComparingTheTwoCalculators_ThenAmountsMatch()
        {
            var yearsSinceAccountCreated = 10;
            var customerType = CustomerType.PlatinumUser;
            var discountedAmountAfterRefactoring = DiscountCalculator.CalculateDiscountedAmount(originalAmount: 10, customerType, yearsSinceAccountCreated);
            var discountedAmountBeforeRefactoring = oldDiscountCalculator.Calculate(amount: 10, (int)customerType, yearsSinceAccountCreated);

            Assert.AreEqual(discountedAmountBeforeRefactoring, discountedAmountAfterRefactoring);
        }
    }
}