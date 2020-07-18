using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAverages
{
    public partial class RandomAverages : Form
    {
        public bool IsValid { get; set; } = true;
        public RandomAverages()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if(long.TryParse(NumberOfValuesTextBox.Text, out long noOfValues))
            {
                #region Listing 1-29
                //ResultValueLabel.Text = ComputeAverages(noOfValues).ToString();
                #endregion

                #region Listing 1-30
                //This Process generates an error.
                //Task.Run(() =>
                //{
                //    ResultValueLabel.Text = ComputeAverages(noOfValues).ToString();
                //});
                #endregion

                #region Listing 1-31
                //In order for this to work you have to make a WPF application

                //Task.Run(() =>
                //{
                //    double result = ComputeAverages(noOfValues);
                    
                //    //ResultValueLabel.Dispat
                //});
                #endregion
            }
            else
            {
                NumberOfValuesTextBox.Text = "Please Enter a valid number.";
                NumberOfValuesTextBox.BackColor = Color.PaleVioletRed;
                IsValid = false;
            }
        }

        private double ComputeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();
            for (long values = 0; values < noOfValues; values++)
            {
                total += rand.NextDouble();
            }
            return total / noOfValues;
        }

        private void NumberOfValuesTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsValid && !string.IsNullOrEmpty(NumberOfValuesTextBox.Text))
            {
                NumberOfValuesTextBox.Text = string.Empty;
                NumberOfValuesTextBox.BackColor = Color.White;
            }
        }
    }
}
