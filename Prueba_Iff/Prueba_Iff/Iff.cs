using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace Prueba_Iff
{
    public partial class Iff : Form
    {

        int edad;
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

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            edad = Convert.ToInt32(TxEdad.Text);

            if (edad < 10)
            {
                MessageBox.Show("es menor de 10 años");
            }
            else if (edad >= 10)
            {
                MessageBox.Show("es mayor a 10 años");
            }
        }

        private void btcomenzar_Click(object sender, EventArgs e)
        {
            //declaracion de variable
            string nombre = "pepe";

            //se convierte la variable a string para poder se utilizad0 su contenido
            nombre = Convert.ToString(TxingresoTXT.Text);

            //else --SiNo--
            if (nombre == "pepe")
            {
                MessageBox.Show("Nombre es pepe"); //mensajevisible para el usuario
            }
            else if(nombre != "pepe" )
            {
                MessageBox.Show("Nombre es distinto de pepe");
            }
           
        }
    }
}

                