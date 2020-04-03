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
            double weight = 50;
            double waterIntake = 0;

            WaterCalculator waterCalculator = new WaterCalculator(weight, waterIntake);
            
            double expectedResult = 0.0435 * weight;

            double actualResult = waterCalculator.CalculateRemainingWaterIntake();

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestCalculateRemainingWaterIntakeWhenWaterHasBeenConsumed()
        {
            double weight = 100;
            double waterIntake = 1;

            WaterCalculator waterCalculator = new WaterCalculator(weight, waterIntake);

            double expectedResult = 0.0435 * weight - waterIntake;

            double actualResult = waterCalculator.CalculateRemainingWaterIntake();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
