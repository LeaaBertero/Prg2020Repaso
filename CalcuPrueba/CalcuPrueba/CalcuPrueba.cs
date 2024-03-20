using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuPrueba
{
    public partial class CalcuPrueba : Form
    {
        public CalcuPrueba()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numSuma1;
                decimal numSuma2;

                decimal resSuma;

                numSuma1 = Convert.ToDecimal(txSum1.Text);
                numSuma2 = Convert.ToDecimal(txSum2.Text);

                resSuma = numSuma1 + numSuma2;

                lbresSuma.Text = "El resultado es: " + " " + resSuma.ToString();

                lbresSuma.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar los campos vacios");
            }

        }

        private void btResta_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numRes1;
                decimal numRes2;

                decimal resResta;

                numRes1 = Convert.ToDecimal(TxRes1.Text);
                numRes2 = Convert.ToDecimal(TxRes2.Text);

                resResta = numRes1 - numRes2;

                lbresResta.Text = "El resultado es: " + " " + resResta.ToString();

                lbresResta.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar los campos vacios");
            }
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numMult1;
                decimal numMult2;

                decimal resMult;

                numMult1 = Convert.ToDecimal(TxMult1.Text);
                numMult2 = Convert.ToDecimal(TxMult2.Text);

                resMult = numMult1 * numMult2;

                lbresMult.Text = "El resultado es: " + " " + resMult.ToString();

                lbresMult.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar los campos vacios");
            }
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numDiv1;
                decimal numDiv2;

                decimal resDiv;

                numDiv1 = Convert.ToDecimal(TxDiv1.Text);
                numDiv2 = Convert.ToDecimal(TxDiv2.Text);

                resDiv = numDiv1 / numDiv2;

                lbresDiv.Text = "El resultado es: " + " " + resDiv.ToString();

                lbresDiv.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar los campos vacios");
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
