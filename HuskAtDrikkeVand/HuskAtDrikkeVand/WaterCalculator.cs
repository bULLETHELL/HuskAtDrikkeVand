using System;
using System.Collections.Generic;
using System.Text;

namespace HuskAtDrikkeVand
{
    public class WaterCalculator
    {   
        // private variables
        private double _weightKg;
        private double _waterAmount;

        // Constructor with two parameters weight in kg and water amount in litres
        public WaterCalculator(double weightKg, double waterAmount)
        {
            this._weightKg = weightKg;
            this._waterAmount = waterAmount;
        }

        // Function to calculate remaining water intake based on weight and already consumed water
        public double CalculateRemainingWaterIntake()
        {
            return _weightKg * 0.0435 - _waterAmount;
        }

    }
}
