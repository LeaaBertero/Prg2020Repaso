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
    public partial class ProyectoPOO : Form
    {
        public ProyectoPOO()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            //form(clase) //variable
            Persona PersonaMostrar;
            //variable        //Clase
            PersonaMostrar = new Persona();

            //PersonaMostrar = new Persona();

            //variable PersonaMostrar es igual a lo que el usuario ingrese en los texbox
            PersonaMostrar.Nombre = TxNombre.Text;
            PersonaMostrar.Apellido = TxApellido.Text;

            //lbMostrar.Text = PersonaMostrar.Nombre + " " + PersonaMostrar.Apellido;

            lbMostrar.Text = PersonaMostrar.NombreCompleto();

            TxNombre.Focus();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
