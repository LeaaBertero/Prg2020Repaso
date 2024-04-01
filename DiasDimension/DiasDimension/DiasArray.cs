using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasDimension
{
    public partial class DiasArray : Form
    {

        public string[] Dias = new string[7];

        public DiasArray()
        {
            InitializeComponent();
        }

        private void btSemana_Click(object sender, EventArgs e)
        {
            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miercoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";


            if (txMostrar.Text == "Ver")
            {
                lbListaSemana.Text = "Dias de la semana " + "\r\n" + "\r\n"
                + Dias[0] + "\r\n"
                + Dias[1] + "\r\n"
                + Dias[2] + "\r\n"
                + Dias[3] + "\r\n"
                + Dias[4] + "\r\n"
                + Dias[5] + "\r\n"
                + Dias[6];
            }

            if (txMostrar.Text != "Ver")
            {
                MessageBox.Show("Ingreso incorrecto");
            }

            if (txMostrar.Text == "")
            {
                MessageBox.Show("Complete el campo requerido");
            }




            lbListaSemana.Visible = true;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txMostrar.Text = "";
            lbListaSemana.Text = "";
        }

        private void btArregloName_Click(object sender, EventArgs e)
        {
            Form arregloNombres = new ArregloNombres();
            arregloNombres.ShowDialog();
        }
    }
}
