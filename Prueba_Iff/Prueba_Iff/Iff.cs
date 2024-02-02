using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Iff
{
    public partial class Iff : Form
    {
        public Iff()
        {
            InitializeComponent();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Form formularioNuevo = new Nuevo();
            formularioNuevo.ShowDialog();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
