using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If
{
    public partial class prueba_Iff : Form
    {
        public prueba_Iff()
        {
            InitializeComponent();
        }

        private void btcomenzar_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroAzar = 0;

                numeroAzar = Convert.ToInt32(txnumero.Text);

                if (numeroAzar < 20)
                {
                    lbresultado.Text = "Número incorrecto";
                    lbresultado.Size = new Size(100, 100);
                    lbresultado.BackColor = Color.Aqua;
                    lbresultado.Visible = true;
                }
                else if (numeroAzar > 7)
                {
                    lbresultado.Text = "Número correcto";
                    lbresultado.BackColor = Color.DeepPink;
                    lbresultado.Size = new Size(200, 200);
                    lbresultado.Visible = true;
                }


                lbresultado.Text = numeroAzar.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                //throw;
            }

        }
        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btprueba2Iff_Click(object sender, EventArgs e)
        {
            Form segundapruebaIff = new pruebaIff_2();
            segundapruebaIff.ShowDialog();
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            txnumero.Text = "";
        }
    }
}







