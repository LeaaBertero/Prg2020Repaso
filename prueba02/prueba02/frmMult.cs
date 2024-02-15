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
    public partial class frmMult : Form
    {
        public frmMult()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCalcularMult_Click(object sender, EventArgs e)
        {
            lbResultMult.Text = Convert.ToString(Restar());
        } 


        private int Restar()
        {
            int numMult1;
            int numMult2;

            int resultMult;

            numMult1 = Convert.ToInt32(txnumMult1.Text);
            numMult2 = Convert.ToInt32(txnumMult2.Text);

            resultMult = numMult1 * numMult2;

            return resultMult;
        }
    }
}
