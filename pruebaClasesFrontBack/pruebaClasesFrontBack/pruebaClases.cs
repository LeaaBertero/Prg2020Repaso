using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaClasesFrontBack
{
    public partial class pruebaClases : Form
    {
        public pruebaClases()
        {
            InitializeComponent();
        }

        private void btejecutar_Click(object sender, EventArgs e)
        {
            //inicializar el objeto de la CLASE persona
            Persona PersonaMostrar = new Persona();


            PersonaMostrar.NombreApellido = txNombre.Text;
            //PersonaMostrar.Apellido = txApellido.Text;
            PersonaMostrar.Documento = Convert.ToInt32(txDocumento.Text);
            PersonaMostrar.Direccion = txDireccion.Text;

            labelLista.Text = PersonaMostrar.Documento + "\r\n" + " " 
                + PersonaMostrar.Direccion.ToString();

            labelLista.Text = PersonaMostrar.NombreCompleto();

        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
