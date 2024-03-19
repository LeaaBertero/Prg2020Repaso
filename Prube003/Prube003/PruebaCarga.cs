using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prube003
{
    public partial class PruebaCarga : Form
    {

        public Persona persona = new Persona();
        //public Persona[] persona = new Persona[2];

        //int posicion = 0;
        

        public PruebaCarga()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            //posicion = posicion + 1;

            persona.Nombre = txNombre.Text;
            txNombre.Focus();
            txNombre.SelectAll();
            txNombre.Text = "";
            

            persona.Apellido = txApellido.Text;
            txApellido.Text = "";

            persona.Documento = Convert.ToInt32(txDocumento.Text);
            txDocumento.Text = "";

        }
        private void txMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n"
                + "Nombre: " + persona.Nombre + "\r\n"
                + "Apellido: " + persona.Apellido + "\r\n"
                + "Documento: " + persona.Documento.ToString();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


