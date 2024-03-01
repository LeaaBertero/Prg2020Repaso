using proyectoCarga.Cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCarga
{
    public partial class CargaPersonas : Form
    {
        //inicializando el objeto
        Cls.Persona persona = new Cls.Persona();

        public CargaPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            persona.Nombre = txCargar.Text;
        }


        private void btmostrar_Click(object sender, EventArgs e)
        {
            lbres.Text = persona.Nombre;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
