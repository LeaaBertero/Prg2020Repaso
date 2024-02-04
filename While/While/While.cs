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
    public partial class While : Form
    {
        public While()
        {
            InitializeComponent();
        }

        private void btejecutar_Click(object sender, EventArgs e)
        {
            Form DoWhile = new DoWhile();
            DoWhile.ShowDialog();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
