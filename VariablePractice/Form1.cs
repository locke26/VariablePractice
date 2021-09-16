using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            outputLabel.Text = playerName + " is number " + playerNumber;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            double circleRadius = 15;
            double circlePi = 3.14;
            double cirlceArea = 706.85;

            outputLabel.Text = $"Radius: {circleRadius} \nPi: {circlePi}";
            outputLabel.Text += $"\nArea: {cirlceArea}";

        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double carpetLength = 8.5;
            double carpetWidth = 6;
            double costPerMeter = 19.95;
            double carpetArea = carpetLength * carpetWidth;
            double totalCost = costPerMeter * carpetArea;

            outputLabel.Text = $"Length: {carpetLength}";
            outputLabel.Text += $"\nWidth: {carpetWidth}";
            outputLabel.Text += $"\nArea: {carpetArea}";
            outputLabel.Text += $"\nCost Per Meter {costPerMeter}";
            outputLabel.Text += $"\nTotal Cost: {totalCost}";

        }

        private void billButton_Click(object sender, EventArgs e)
        {

        }
    }
}
