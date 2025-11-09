using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BMIberekenen_Click(object sender, EventArgs e)
        {
            float gewicht = float.Parse(txtGewicht.Text);
            float lengte = float.Parse(txtLengte.Text) / 100;
            float leeftijd = float.Parse(txtLeeftijd.Text);


            float BMI = (gewicht / (lengte * lengte));
            int BMIint = (int)Math.Round(BMI);

            string advies = "hier komt het advies";

            if (BMI < 18.5)
            {
                advies = "ondergewicht";
            }
            if (BMI > 18.5 && BMI < 24.9)
            {
                advies = "Normaal";
            }
            if (BMI > 25 && BMI < 29.9)
            {
                advies = "Overgewicht";
            }
            if (BMI > 30 && BMI < 39.9)
            {
                advies = "Zwaar Overgewicht";
            }
            if (BMI > 40)
            {
                advies = "Gevaarlijk Overgewicht";
            }

            lblBMI.Text = BMIint.ToString();
            lblAdvies.Text = advies;
        }
    }
}
