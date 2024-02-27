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
    public partial class frmResta : Form
    {
        public frmResta()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcalcularRes_Click(object sender, EventArgs e)
        {
            lbresultResta.Text = Convert.ToString(Resta());

        }

        //método
        private int Resta()
        {
            try
            {
                int numRes1;
                int numRes2;

                int resultRes;

                numRes1 = Convert.ToInt32(txnumRes1.Text);
                numRes2 = Convert.ToInt32(txnumRes2.Text);

                resultRes = numRes1 - numRes2;

                return resultRes;
            }
            catch (Exception)
            {
                MessageBox.Show("No se admiten espacios vacios");
                throw;
            }
        }

        private void BtLimpiarResta_Click(object sender, EventArgs e)
        {
            txnumRes1.Text = "";
            txnumRes2.Text = "";
        }
    }
}
