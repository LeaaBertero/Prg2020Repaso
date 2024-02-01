using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora : Form
    {
        //variables para suma
        int numSuma1;
        int numSuma2;
        int resSuma;

        //variables para resta
        int numResta1;
        int numResta2;
        int resResta;

        //variables para multiplicación
        int numMult1;
        int numMult2;
        int resMult;

        //variables para división
        int numDiv1;
        int numDiv2;
        int resDiv;

        public calculadora()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            try
            {
                numSuma1 = Convert.ToInt32(txsuma1.Text);
                numSuma2 = Convert.ToInt32(txsuma2.Text);

                resSuma = numSuma1 + numSuma2;

                lbresultado.Text = "El resultado de la suma es = " + " " + resSuma.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible sumar datos vacios");
            }


        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            //txtbox suma
            txsuma1.Text = null;
            txsuma2.Text = null;

            //texbox resta
            txresta1.Text = null;
            txresta2.Text = null;

            //txboxmultiplicacion
            txmult1.Text = null;
            txmult2.Text = null;

            //txdivision
            txdiv1.Text = null;
            txdiv2.Text = null;

            //label de resultado
            lbresultado.Text = null;
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            try
            {
                numResta1 = Convert.ToInt32(txresta1.Text);
                numResta2 = Convert.ToInt32(txresta2.Text);

                resResta = numResta1 - numResta2;

                lbresultado.Text = "El resultado de la suma es = " + " " + resResta.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible restar datos vacios");
            }
        }

        private void btmultip_Click(object sender, EventArgs e)
        {
            try
            {
                numMult1 = Convert.ToInt32(txmult1.Text);
                numMult2 = Convert.ToInt32(txmult2.Text);

                resMult = numMult1 * numMult2;

                lbresultado.Text = "El resultado de la suma es = " + " " + resMult.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible multiplicar datos vacios");
            }
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            try
            {
                numDiv1 = Convert.ToInt32(txdiv1.Text);
                numDiv2 = Convert.ToInt32(txdiv2.Text);

                resDiv = numDiv1 / numDiv2;

                lbresultado.Text = "El resultado de la suma es = " + " " + resDiv.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible dividir datos vacios");
            }
        }
    }
}
