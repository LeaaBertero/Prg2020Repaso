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
        proyectoCarga.Cls.Persona personas = new proyectoCarga.Cls.Persona();

        public CargaPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            personas.Nombre = txNombre.Text;
            personas.AñoNacimiento = txañoNacimiento.Text;
        }


        public void btmostrar_Click(object sender, EventArgs e)
        {
            lbres.Text = " \r\n " + " Nombre: " + personas.Nombre + " \r\n " + " Año: " + personas.AñoNacimiento;
            
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
