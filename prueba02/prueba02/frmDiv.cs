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
    public partial class frmDiv : Form
    {
        public frmDiv()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btdivCalcular_Click(object sender, EventArgs e)
        {



            lbresultDiv.Text = Convert.ToString(Dividir());

        }

        private int Dividir()
        {
            int numDiv1;
            int numDiv2;

            int resultDiv;

            numDiv1 = Convert.ToInt32(txnumMult1.Text);
            numDiv2 = Convert.ToInt32(txnumMult2.Text);

            resultDiv = numDiv1 / numDiv2;

            return resultDiv;
        }

        private void BtLimpiarDiv_Click(object sender, EventArgs e)
        {
            txnumMult1.Text = "";
            txnumMult2.Text = "";
        }
    }
}
