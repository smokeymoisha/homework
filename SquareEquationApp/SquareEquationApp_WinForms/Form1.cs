using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquareEquationApp_dll;

namespace SquareEquationApp_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void a_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var stringA = txtA.Text;
            var stringB = txtB.Text;
            var stringC = txtC.Text;
            
            double a;
            if (double.TryParse(stringA, out a) == false)
            {
                MessageBox.Show("Supplied value 'a' is not a number, please try again");
            }

            double b;
            if (double.TryParse(stringB, out b) == false)
            {
                MessageBox.Show("Supplied value 'b' is not a number, please try again");
            }

            double c;
            if (double.TryParse(stringC, out c) == false)
            {
                MessageBox.Show("Supplied value 'c' is not a number, please try again");
            }

            var discriminant = SquareEquationMath.Discriminant(a, b, c);
            if (discriminant < 0)
            {
                MessageBox.Show("D < 0, equation has no roots!");
            }

            var firstRoot = SquareEquationMath.FirstRoot(discriminant, a, b);
            var secondRoot = SquareEquationMath.SecondRoot(discriminant, a, b);

            lblDiscriminant.Text = discriminant.ToString();
            lblFirstRoot.Text = firstRoot.ToString();
            lblSecondRoot.Text = secondRoot.ToString();
            lblPolyFactor.Text = $"{a}x² + {b}x + {c} = {a}*(x - {firstRoot:F2})*(x - {secondRoot:F2})";
        }
    }
}
