using System;
using System.Collections.Generic;
using System.Text;

namespace HuskAtDrikkeVand
{
    public class WaterCalculator
    {
        private double _weightKg;
        private double _waterAmount;

        public WaterCalculator(double weightKg, double waterAmount)
        {
            this._weightKg = weightKg;
            this._waterAmount = waterAmount;
        }

        public double CalculateRemainingWaterIntake()
        {
            return _weightKg * 0.0435 - _waterAmount;
        }

    }
}
