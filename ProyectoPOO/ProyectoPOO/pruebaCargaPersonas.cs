using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class pruebaCargaPersonas : Form
    {
        public pruebaCargaPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;

            nombre = txnombre.Text;
            apellido = txapellido.Text;

            lbmostrar.Text = nombre + " " + apellido;
        }
    }
}
