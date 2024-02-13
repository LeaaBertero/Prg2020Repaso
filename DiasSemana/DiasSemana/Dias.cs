using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasSemana
{
    public partial class Dias : Form
    {

        string[] DiasSemana = new string[7];

        public Dias()
        {
            InitializeComponent();
        }

        private void btcomenzar_Click(object sender, EventArgs e)
        {
            DiasSemana[0] = lblunes.Text = "Lunes";
            lblunes.Visible = true;

        }

        private void btsegundo_Click(object sender, EventArgs e)
        {
            DiasSemana[1] = lbmates.Text = "Martes";
            lbmates.Visible = true;
        }

        private void btTercero_Click(object sender, EventArgs e)
        {
            DiasSemana[2] = lbmiercoles.Text = "Miercoles";
            lbmiercoles.Visible = true;
        }

        private void btcuarto_Click(object sender, EventArgs e)
        {
            DiasSemana[3] = lbjueves.Text = "Jueves";
            lbjueves.Visible = true;
        }

        private void btquinto_Click(object sender, EventArgs e)
        {
            DiasSemana[4] = lbviernes.Text = "Viernes";
            lbviernes.Visible = true;
        }

        private void btsexto_Click(object sender, EventArgs e)
        {
            DiasSemana[5] = lbsabado.Text = "Sábado";
            lbsabado.Visible = true;
        }

        private void btseptimo_Click(object sender, EventArgs e)
        {
            DiasSemana[6] = lbdomingo.Text = "Domingo";
            lbdomingo.Visible = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            lblunes.Text = null;
            lbmates.Text = null;
            lbmiercoles.Text = null;
            lbjueves.Text = null;
            lbviernes.Text = null;
            lbsabado.Text = null;
            lbdomingo.Text = null;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
