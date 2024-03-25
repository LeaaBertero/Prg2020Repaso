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
                Form arregloPrueba = new ArregloPrueba();
                arregloPrueba.Show();
            }
            else if (txClave.Text == null)
            {
                lbMensajeError.Text = "Debe completar el campo que solicitado";
                lbMensajeError.Visible = true;
            }
            else
            {
                lbMensajeError.Text = "Clave incorrecta";
                lbMensajeError.Visible = true;
            }




        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
