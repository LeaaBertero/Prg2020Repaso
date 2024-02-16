using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operadores
{
    public partial class operadores1 : Form
    {
        int numero = 0;
        public operadores1()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //int numero1;
            //int numero2;

            //int resultado;

            //numero1 = Convert.ToInt32(txnum1.Text);
            //numero2 = Convert.ToInt32(txnum2.Text);

            //resultado = numero1 + numero2;

            laresultado.Text = "El resultado es:" + " " + Convert.ToString(Suma());
            laresultado.Visible = true;
        }

        private int Suma()
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = Convert.ToInt32(txnum1.Text);
            numero2 = Convert.ToInt32(txnum2.Text);

            resultado = numero1 + numero2;

            return resultado;

        }

        private void btincremento_Click(object sender, EventArgs e)
        {
            

            numero = ++numero;

            if (numero == 10)
            {
                MessageBox.Show("Ha llegado al limite de 10");
            }
            else if (numero == 20)
            {
                BackColor = Color.Red;
                
            }
            else if ( numero > 20 )
            {
                BackColor = Color.Black;
                lbincremento.BackColor = Color.HotPink;
                //lbincremento.ForeColor = Color.White;
                lbincremento.Size = new Size(200, 200);
                lbincremento.ForeColor = Color.White;
                label3.ForeColor = Color.White; 
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                laresultado.ForeColor = Color.White;


            }
            

            lbincremento.Text = Convert.ToString(numero);
        }
    }
}
