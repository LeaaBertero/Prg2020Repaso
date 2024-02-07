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
                    lblResultado.Text = "No aprobado";
                    lblResultado.Visible = true;
                    break;
                case "cuatro":
                    lblResultado.Text = "Regular";
                    lblResultado.Visible = true;
                    break;
                case "siete":
                    lblResultado.Text = "Promocionado";
                    lblResultado.Visible = true;
                    break;
                case "diez":
                    lblResultado.Text = "Aprobado";
                    lblResultado.Visible = true;
                    break;
                default:
                    lblResultado.Text = "Nota no valida";
                    break;                   
            }
        }
    }
}
