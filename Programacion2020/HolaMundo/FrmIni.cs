using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class FrmIni : Form
    {
        public FrmIni()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btini_Click(object sender, EventArgs e)
        {
            lbnombre.Text = "Hola Leann, cómo estas hoy?";
        }
    }
}
