using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionPersona
{
    public partial class Calcu : Form
    {
        public Calcu()
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
                lbresSuma.Text = Convert.ToString(Suma());
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

            lbresSuma.Visible = true;
        }

        public int Suma()
        {
            int numero1;
            int numero2;
            int resultadoSuma;


            numero1 = Convert.ToInt32(txSuma1.Text);
            numero2 = Convert.ToInt32(txSuma2.Text);

            resultadoSuma = numero1 + numero2;

            return resultadoSuma;
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            try
            {
                lbResResta.Text = Resta().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

            lbResResta.Visible = true;
        }

        private int Resta()
        {
            int numeroResta1;
            int numeroResta2;
            int resultadoResta;

            numeroResta1 = Convert.ToInt32(txResta1.Text);
            numeroResta2 = Convert.ToInt32(txResta2.Text);

            resultadoResta = numeroResta1 - numeroResta2;

            return resultadoResta;
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                lbResMult.Text = Convert.ToString(Multiplicacion());
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los campos");
            }

            lbResMult.Visible = true;
        }


        private int Multiplicacion()
        {
            int numMut1;
            int numMut2;
            int resultadoMut;

            numMut1 = Convert.ToInt32(txMult1.Text);
            numMut2 = Convert.ToInt32(txMult2.Text);

            resultadoMut = numMut1 * numMut2;

            return resultadoMut;
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                //LbResDiv.Text = Convert.ToString(Division());
                LbResDiv.Text = Division().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

            LbResDiv.Visible = true;
        }

        private int Division()
        {
            int numDiv1;
            int numDiv2;
            int resultadoDiv;

            numDiv1 = Convert.ToInt32(txDiv1.Text);
            numDiv2 = Convert.ToInt32(txDiv2.Text);

            resultadoDiv = numDiv1 / numDiv2;

            return resultadoDiv;
        }

        private void btlimpSuma_Click(object sender, EventArgs e)
        {
            txSuma1.Text = "";
            txSuma2.Text = "";
            lbresSuma.Text = "";
        }

        private void btLimpiarRes_Click(object sender, EventArgs e)
        {
            txResta1.Text = "";
            txResta2.Text = "";
            lbResResta.Text = "";
        }

        private void BtLimpiarMult_Click(object sender, EventArgs e)
        {
            txMult1.Text = "";
            txMult2.Text = "";
            lbResMult.Text = "";
        }

        private void BtLimpiarDiv_Click(object sender, EventArgs e)
        {
            txDiv1.Text = "";
            txDiv2.Text = "";
            LbResDiv.Text = "";
        }
    }



}
