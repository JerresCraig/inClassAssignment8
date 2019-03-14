using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClassAssignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Jerres Craig
        //This is my own work
        private void button1_Click(object sender, EventArgs e)
        {
            //get the fat and carb grams
            double fatGrams = double.Parse(txtFat.Text);
            double carbGrams = double.Parse(txtCarb.Text);

            double fatResult = fatCalories(fatGrams);
            this.lblResult.Text = "The calories from fat are " + fatResult;
            double carbResult = carbCalories(carbGrams);
            this.lblResult2.Text = "the calories from carbs are " + carbResult;
        }
        //methods
        //both methods calculate the number of calories
        // they do this fromt he grams of fat and carbs that the user inputs
        private double fatCalories(double fatG)
        {
            return fatG * 9;
        }

        private double carbCalories(double carbG)
        {
            return carbG * 4;
        }
    }
}
