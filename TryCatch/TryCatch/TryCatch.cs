using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class TryCatch : Form
    {
        
        public TryCatch()
        {
            InitializeComponent();
        }

        private void btsumar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numero1;
                decimal numero2;

                decimal resultado;

                numero1 = Convert.ToDecimal(txnum1.Text);
                numero2 = Convert.ToDecimal(txnum2.Text);

                resultado = numero1 + numero2;

                labelresultado.Text = resultado.ToString();

                labelresultado.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar campos vacios al realizar la operación");
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
