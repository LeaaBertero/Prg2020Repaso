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
    public partial class Calculadora : Form
    {
        //constructor
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            //variables para suma
            decimal numSuma1;
            decimal numSuma2;
            decimal resSuma;

            try
            {
                numSuma1 = Convert.ToDecimal(txsuma1.Text);
                numSuma2 = Convert.ToDecimal(txsuma2.Text);

                resSuma = numSuma1 + numSuma2;

                lbresultado.Text = "El resultado de la suma es = " + " " + resSuma.ToString();
                lbresultado.Visible = true;
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
            //variables para resta
            decimal numResta1;
            decimal numResta2;
            decimal resResta;

            try
            {
                numResta1 = Convert.ToDecimal(txresta1.Text);
                numResta2 = Convert.ToDecimal(txresta2.Text);

                resResta = numResta1 - numResta2;

                lbresultado.Text = "El resultado de la resta es = " + " " + resResta.ToString();
                lbresultado.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible restar datos vacios");
            }
        }

        private void btmultip_Click(object sender, EventArgs e)
        {
            //variables para multiplicación
            decimal numMult1;
            decimal numMult2;
            decimal resMult;

            try
            {
                numMult1 = Convert.ToDecimal(txmult1.Text);
                numMult2 = Convert.ToDecimal(txmult2.Text);

                resMult = numMult1 * numMult2;

                lbresultado.Text = "El resultado de la multiplicación es = " + " " + resMult.ToString();
                lbresultado.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible multiplicar datos vacios");
            }
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            //variables para división
            decimal numDiv1;
            decimal numDiv2;
            decimal resDiv;

            try
            {
                numDiv1 = Convert.ToDecimal(txdiv1.Text);
                numDiv2 = Convert.ToDecimal(txdiv2.Text);

                resDiv = numDiv1 / numDiv2;

                lbresultado.Text = "El resultado de la división es = " + " " + resDiv.ToString();
                lbresultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible dividir datos vacios");
            }
        }
    }
}
