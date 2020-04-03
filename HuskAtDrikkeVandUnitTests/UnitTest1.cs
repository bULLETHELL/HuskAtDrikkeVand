using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using HuskAtDrikkeVand;
namespace HuskAtDrikkeVandUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateRemainingWaterIntakeWhenNoWaterHasBeenConsumed()
        {
            // Variables
            double weight = 50;
            double waterIntake = 0;

            // Mock object
            WaterCalculator waterCalculator = new WaterCalculator(weight, waterIntake);
            
            // Expected Result
            double expectedResult = 0.0435 * weight;

            // Actual result calls the function we're testing
            double actualResult = waterCalculator.CalculateRemainingWaterIntake();

            // Check if the two results are equal
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestCalculateRemainingWaterIntakeWhenWaterHasBeenConsumed()
        {
            // Variables
            double weight = 100;
            double waterIntake = 1;

            // Mock object
            WaterCalculator waterCalculator = new WaterCalculator(weight, waterIntake);

            // Expected Result
            double expectedResult = 0.0435 * weight - waterIntake;

            // Actual result calls the function we're testing
            double actualResult = waterCalculator.CalculateRemainingWaterIntake();

            // Check if the two results are equal
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
