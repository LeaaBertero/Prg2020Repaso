using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Segun_Prueba
{
    public partial class Switch_2 : Form
    {
        public Switch_2()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            string nota;

            nota = Convert.ToString(TXIngresar.Text);

            switch (nota)
            {
                case "uno":
                    label1.Text = "No aprobado";
                    break;
                case "cuatro":
                    label1.Text = "Regular";
                    break;
                case "siete":
                    label1.Text = "Promocionado";
                    break;
                case "diez":
                    label1.Text = "Aprobado";
                    break;
                default:
                    label1.Text = "Nota no valida";
                    break;                   
            }
        }
    }
}
