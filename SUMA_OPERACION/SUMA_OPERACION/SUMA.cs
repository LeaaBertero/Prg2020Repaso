using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUMA_OPERACION
{
    public partial class SUMA : Form
    {
        public SUMA()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            int resultado;

            numero1 = Convert.ToInt32(txnum1.Text);
            numero2 = Convert.ToInt32(txNum2.Text);

            resultado = numero1 + numero2;

            //txnum1.Focus();

            MessageBox.Show("El resultado es: " + "\r\n" + resultado.ToString());


        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
