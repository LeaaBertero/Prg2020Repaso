using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba02
{
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            lbresultadoSuma.Text = Convert.ToString(sumar());
        }

        //método privado que devuelve resultado
        //de la operación de la suma en este caso
        private int sumar()
        {

            try
            {
                int numSuma1;
                int numSuma2;

                int resultSuma;

                numSuma1 = Convert.ToInt32(txnumSuma1.Text);
                numSuma2 = Convert.ToInt32(txnumSuma2.Text);

                resultSuma = numSuma1 + numSuma2;

                return resultSuma;
            }
            catch (Exception)
            {
                MessageBox.Show("No se admiten espacios vacios");
                throw;
            }


        }

        private void btLimpiarSuma_Click(object sender, EventArgs e)
        {
            txnumSuma1.Text = "";
            txnumSuma2.Text = "";
        }
    }
}
