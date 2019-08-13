using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e) //adds number of people to the event, passes the cast int to numberOfPeople field in the DinnerPArty Class
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void FancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;                //being checkmarked will pass a boolean value to the class's method as an argument,
            DisplayDinnerPartyCost();                                       //allowing the method to return a value back (extra cost or no extra cost)
        }

        private void HealthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;                 //being checked mark ... pass boolean value ... lets method return a value ... extra cost added if checkedmarked
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;                            //being checkmarked will pass a boolean value as an argument letting the program as extra costs or not.
            costLabel1.Text = Cost.ToString("c");                       //passing "c" ToString tells it to format it as currency
        }
    }
}
