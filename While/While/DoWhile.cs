using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMover_Click(object sender, EventArgs e)
        {

        }

        private void DoWhile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, puede hacer aquí todo lo que quieras..");
        }
    }
}
