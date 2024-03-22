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

        //Evento click
        private void btsuma_Click(object sender, EventArgs e)
        {
            try
            {
                lbresSuma.Text = "Resultado:" + " " + Convert.ToString(Suma());
                lbresSuma.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

           
        }

        //Método
        public decimal Suma()
        {
            decimal numero1;
            decimal numero2;
            decimal resultadoSuma;


            numero1 = Convert.ToDecimal(txSuma1.Text);
            numero2 = Convert.ToDecimal(txSuma2.Text);

            resultadoSuma = numero1 + numero2;

            return resultadoSuma;
        }

        //Evento Click
        private void btResta_Click(object sender, EventArgs e)
        {
            try
            {
                lbResResta.Text = "Resultado:" + " " + Resta().ToString();
                lbResResta.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

            
        }

        //Método
        private decimal Resta()
        {
            decimal numeroResta1;
            decimal numeroResta2;
            decimal resultadoResta;

            numeroResta1 = Convert.ToDecimal(txResta1.Text);
            numeroResta2 = Convert.ToDecimal(txResta2.Text);

            resultadoResta = numeroResta1 - numeroResta2;

            return resultadoResta;
        }

        //Evento Click
        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                lbResMult.Text = "Resultado:" + " " + Convert.ToString(Multiplicacion());
                lbResMult.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los campos");
            }

            
        }

        //Método
        private decimal Multiplicacion()
        {
            decimal numMut1;
            decimal numMut2;
            decimal resultadoMut;

            numMut1 = Convert.ToDecimal(txMult1.Text);
            numMut2 = Convert.ToDecimal(txMult2.Text);

            resultadoMut = numMut1 * numMut2;

            return resultadoMut;
        }

        //Evento Click
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                //LbResDiv.Text = Convert.ToString(Division());
                //LbResDiv.Text = "Resultado:" + " " + Division().ToString();
                LbResDiv.Text = "Resultado" + " " + Convert.ToDecimal(Division());
                LbResDiv.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Complete todos los campos");
            }

           
        }

        //Método
        private decimal Division()
        {
            decimal numDiv1;
            decimal numDiv2;
            decimal resultadoDiv;

            numDiv1 = Convert.ToDecimal(txDiv1.Text);   
            numDiv2 = Convert.ToDecimal(txDiv2.Text);

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
