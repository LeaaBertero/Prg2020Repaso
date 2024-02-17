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
    public partial class pruebaIff_2 : Form
    {
        public pruebaIff_2()
        {
            InitializeComponent();
        }

        private void btsalir2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsumar2_Click(object sender, EventArgs e)
        {
            if (txoper.Text == "+")
            {
                int numero1;
                int numero2;

                int resultado;

                numero1 = Convert.ToInt32(txnum1.Text);
                numero2 = Convert.ToInt32(txnum2.Text);

                resultado = numero1 + numero2;

                lbresultado.Text = resultado.ToString();
            }
            else if (txoper.Text == "-")
            {
                int numero1;
                int numero2;

                int resultado;

                numero1 = Convert.ToInt32(txnum1.Text);
                numero2 = Convert.ToInt32(txnum2.Text);

                resultado = numero1 - numero2;

                lbresultado.Text = resultado.ToString();
            }
            else if(txoper.Text == "*") 
            {
                int numero1;
                int numero2;

                int resultado;

                numero1 = Convert.ToInt32(txnum1.Text);
                numero2 = Convert.ToInt32(txnum2.Text);

                resultado = numero1 * numero2;

                lbresultado.Text = resultado.ToString();
            }
            else if(txoper.Text == "/")
            {
                int numero1;
                int numero2;

                int resultado;

                numero1 = Convert.ToInt32(txnum1.Text);
                numero2 = Convert.ToInt32(txnum2.Text);

                resultado = numero1 / numero2;

                lbresultado.Text = resultado.ToString();
            }

        }
    }
}
