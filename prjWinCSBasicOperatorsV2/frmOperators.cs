using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCSBasicOperatorsV2
{
    public partial class frmOperators : Form
    {
        float value1, value2;

        public frmOperators()
        {
            InitializeComponent();
        }

        private void getTxtValue()
        {
            value1 = Convert.ToInt32(txtValue1.Text);
            value2 = Convert.ToInt32(txtValue2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float resoult = 0;
            getTxtValue();

            if (radAddition.Checked)
            {
                resoult = value1 + value2;
            }
            else if (radSubstraction.Checked)
            {
                resoult = value1 - value2;
            }
            else if (radDivision.Checked)
            {
                resoult = value1 / value2;
            }
            else if (radMultiplication.Checked)
            {
                resoult = value1 * value2;
            }
            txtDisplayRes.Text = resoult.ToString();

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            bool comparisonResoult = false;
            getTxtValue();

            if (radGreat.Checked)
            {
                comparisonResoult = value1 > value2;
            }
            else if (radSmall.Checked)
            {
                comparisonResoult = value1 < value2;
            }
            else if (radDifferent.Checked)
            {
                comparisonResoult = value1 != value2;
            }
            else if (radEqual.Checked)
            {
                comparisonResoult = value1 == value2;
            }
            txtDisplayRes.Text = comparisonResoult.ToString();
        }

        private void chArithmetics_CheckedChanged(object sender, EventArgs e)
        {
            btnCompute.Enabled = chArithmetics.Checked;
            chComparison.Checked = !chArithmetics.Checked;

        }

        private void chComparison_CheckedChanged(object sender, EventArgs e)
        {
            btnEvaluate.Enabled = chComparison.Checked;
            chArithmetics.Checked = !chComparison.Checked;
        }


    }
}
