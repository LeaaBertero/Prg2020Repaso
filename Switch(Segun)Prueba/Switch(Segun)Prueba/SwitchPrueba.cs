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
    public partial class SwitchPrueba : Form
    {
        public SwitchPrueba()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
            //btSalir.BackColor = Color.Violet;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            //lblrespuesta.Text = Convert.ToString(txingresar.Text);
            int edad = Convert.ToInt32(txingresar.Text);
            btaceptar.BackColor = Color.Orange;

            switch (edad)
            {
                case 12:
                    lblrespuesta.Text = "Niño";
                    break;

                case 16:
                    lblrespuesta.Text = "Adolescente";
                    break;

                case 18:
                    lblrespuesta.Text = "Mayor de edad";
                    break;

                case 21:
                    lblrespuesta.Text = "Mayor de 21, ya casi viejo";
                    break;

                case 40:
                    lblrespuesta.Text = "Viejo ";
                    break;

                default:
                    lblrespuesta.Text = "dato no valido";
                    break;
            }

            lblrespuesta.Visible = true;

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Form Switch2 = new Switch_2();
            Switch2.ShowDialog();
        }
    }
}
                    


