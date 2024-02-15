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
    public partial class prueba02 : Form
    {
        public prueba02()
        {
            InitializeComponent();
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            Form frmsuma = new frmSuma();
            frmsuma.ShowDialog();

            BackColor = Color.Blue;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            Form frmResta = new frmResta();
            frmResta.ShowDialog();

            BackColor = Color.Red;
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            Form frmMult = new frmMult();
            frmMult.ShowDialog();

            BackColor = Color.Yellow;
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            Form formDiv = new frmDiv();
            formDiv.ShowDialog();

            BackColor = Color.Green;
        }

      
    }
}
