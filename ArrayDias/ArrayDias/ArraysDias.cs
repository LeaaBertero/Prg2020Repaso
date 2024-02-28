using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDias
{
    public partial class ArraysDias : Form
    {
        public ArraysDias()
        {
            InitializeComponent();
        }

        private void btdias_Click(object sender, EventArgs e)
        {
            string[] Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miercoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";


            lbLunes.Text = Dias[0];
            lbMartes.Text = Dias[1];
            Lbmiercoles.Text = Dias[2];
            LbJueves.Text = Dias[3];
            LbViernes.Text = Dias[4];
            lbSabado.Text = Dias[5];
            LbDomingo.Text = Dias[6];

            lbLunes.Visible = true;
            lbMartes.Visible = true;
            Lbmiercoles.Visible = true;
            LbJueves.Visible = true;
            LbViernes.Visible = true;
            lbSabado.Visible = true;
            LbDomingo.Visible = true;

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            lbLunes.Text = "";
            lbMartes.Text = "";
            Lbmiercoles.Text = "";
            LbJueves.Text = "";
            LbViernes.Text = "";
            lbSabado.Text = "";
            LbDomingo.Text = "";
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
