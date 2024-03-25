using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloPrueba
{
    public partial class FrmKey : Form
    {
        public FrmKey()
        {
            InitializeComponent();
        }

        private void btClave_Click(object sender, EventArgs e)
        {
            if (txClave.Text == "entrar")
            {
                txClave.Text = "";
                Form arregloPrueba = new ArregloPrueba();
                arregloPrueba.Show();
            }
            else if (txClave.Text == "")
            {
                MessageBox.Show("Debe completar el campo solicitado");
                //lbMensajeError.Text = "Debe completar el campo solicitado";
                //lbMensajeError.Visible = true;
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            }
        }



        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txClave.Text = "";
        }

      
    }
}
