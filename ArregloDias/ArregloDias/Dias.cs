using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloDias
{
    public partial class Dias : Form
    {
        //Dimension del arreglo
        public string[] diasSemana = new string[7];

        public Dias()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {

            diasSemana[0] = "Lunes";
            diasSemana[1] = "Martes";
            diasSemana[2] = "Miercoles";
            diasSemana[3] = "Jueves";
            diasSemana[4] = "Viernes";
            diasSemana[5] = "Sábado";
            diasSemana[6] = "Domingo";

            lbDias.Visible = true;

            lbDias.Text = "Dias de la semana" + "\r\n" + "\r\n" + diasSemana[0]
                + "\r\n"
                + diasSemana[1] + "\r\n"
                + diasSemana[2] + "\r\n"
                + diasSemana[3] + "\r\n"
                + diasSemana[4] + "\r\n"
                + diasSemana[5] + "\r\n"
                + diasSemana[6];
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
