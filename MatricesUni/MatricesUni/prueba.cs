using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesUni
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //variables enteras para suma
                int numero1;
                int numero2;
                int res;

                numero1 = Convert.ToInt32(txsuma1.Text);
                numero2 = Convert.ToInt32(txsuma2.Text);

                res = numero1 + numero2;

                labeRes.Text = Convert.ToString(res);
            }
            catch (Exception)
            {

                MessageBox.Show("No se permiten valores null");
            }
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            try
            {
                //variables enteras para resta
                int numres1;
                int numres2;
                int resRes;

                numres1 = Convert.ToInt32(txresta1.Text);
                numres2 = Convert.ToInt32(txresta2.Text);

                resRes = numres1 - numres2;

                labelresta.Text = Convert.ToString(resRes);
            }
            catch (Exception)
            {
                MessageBox.Show("No se permiten valores null");
                //throw;
            }
        }

        private void btresmult_Click(object sender, EventArgs e)
        {
            try
            {
                //variables enteras para resta
                int numMul1;
                int numMult2;
                int resMult;

                numMul1 = Convert.ToInt32(txmult1.Text);
                numMult2 = Convert.ToInt32(txmult2.Text);

                resMult = numMul1 * numMult2;

                labelMult.Text = Convert.ToString(resMult);
            }
            catch (Exception)
            {
                MessageBox.Show("No se permiten valores null");

                //throw;
            }
        }

        private void btresdiv_Click(object sender, EventArgs e)
        {
            try
            {
                //variables enteras para resta
                int numdiv1;
                int numdiv2;
                int resdiv;

                numdiv1 = Convert.ToInt32(txdiv1.Text);
                numdiv2 = Convert.ToInt32(txdiv2.Text);

                resdiv = numdiv1 / numdiv2;

                labelresdiv.Text = Convert.ToString(resdiv);
            }
            catch (Exception)
            {
                MessageBox.Show("No se permiten valores null");

                //throw;
            }
        }
    }
}


