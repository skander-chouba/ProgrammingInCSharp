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
        private async void StartButton_Click(object sender, EventArgs e)
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

                #region Listing 1-32
                ResultValueLabel.Text = "Calculating...";
                double result = await ComputeAveragesAsync(noOfValues);
                ResultValueLabel.Text = result.ToString();
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

        /// <summary>
        /// The async and await keywords allow programmers to write code elements that execute asynchronously.
        /// The async keyword is used to flag a method as “asynchronous.”
        /// An asynchronous method must contain one or more actions that are “awaited.”
        /// 
        /// An action can be awaited if it returns either a Task (I just want do something asynchronously)
        /// or a Task<t> (I want to do something asynchronously that returns a result of a particular type).
        /// </summary>
        /// <param name="noOfValues"></param>
        /// <returns></returns>
        private Task<double> ComputeAveragesAsync(long noOfValues)
        {
            return Task.Run(() =>
            {
                return ComputeAverages(noOfValues);
            });
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
