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

        private void calculateButton_Clicked(object sender, EventArgs e)
        {
            double remainingWaterIntake;
            WaterCalculator waterCalculator = new WaterCalculator(Double.Parse(weightEntry.Text), Double.Parse(waterAmountEntry.Text));

            remainingWaterIntake = waterCalculator.CalculateRemainingWaterIntake();

            remainingWaterIntakeLabel.Text = String.Format("Du mangler at drikke {0} liter vand", remainingWaterIntake.ToString());
        }
    }
}
