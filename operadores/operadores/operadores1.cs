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

            laresultado.Text = Convert.ToString(Suma());
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
    }
}
