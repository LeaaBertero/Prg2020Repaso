using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            string[]Dias = new string[7];

            Dias[0] = "Lunes";
            Dias[1] = "Martes";
            Dias[2] = "Miércoles";
            Dias[3] = "Jueves";
            Dias[4] = "Viernes";
            Dias[5] = "Sábado";
            Dias[6] = "Domingo";


            lbLunes.Visible = true;
            //lbMartes.Visible = true;
            //lbMiercoles.Visible = true;
            //lbJueves.Visible = true;
            //lbViernes.Visible = true;
            //lbsabado.Visible = true;
            //lbDomingo.Visible = true;

            //lbLunes.Text = Dias[0];
            //lbMartes.Text = Dias[1];
            //lbMiercoles.Text = Dias[2];
            //lbJueves.Text = Dias[3];
            //lbViernes.Text = Dias[4];
            //lbsabado.Text = Dias[5];
            //lbDomingo.Text = Dias[6];

            for (int incremento = 0; incremento < Dias.Length; incremento++)
            {
                lbLunes.Text = lbLunes.Text + " " + Dias[incremento] + " " + "\r\n";
            }

            //foreach (string incremento in Dias)
            //{
            //    lbLunes.Text = lbLunes.Text + " " + incremento + " " + "\r\n";
            //}

        }
    }
}
