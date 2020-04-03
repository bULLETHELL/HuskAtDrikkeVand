using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HuskAtDrikkeVand
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Calculate Button Clicked Event Handler
        private void calculateButton_Clicked(object sender, EventArgs e)
        {
            double remainingWaterIntake; 
            // Instantiation of new WaterCalculator object
            WaterCalculator waterCalculator = new WaterCalculator(Double.Parse(weightEntry.Text), Double.Parse(waterAmountEntry.Text));

            // Call to CalculateRemainingWaterIntake function
            remainingWaterIntake = waterCalculator.CalculateRemainingWaterIntake();

            // Set Text property of remainingWaterIntakeLabel to string with remainingWaterIntake variable
            remainingWaterIntakeLabel.Text = String.Format("Du mangler at drikke {0} liter vand", remainingWaterIntake.ToString());
        }
    }
}
