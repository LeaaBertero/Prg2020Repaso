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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            Form formularioIff = new Iff();
            formularioIff.ShowDialog();


        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
