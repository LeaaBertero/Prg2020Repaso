using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Ini
{
    public partial class Switch : Form
    {
        public Switch()
        {
            InitializeComponent();
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            Form formularioSwitch = new Ejercitacion_switch();
            formularioSwitch.ShowDialog();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    int nota;

                    nota = Convert.ToInt32(txIngresar.Text);

                    switch (nota)
                    {
                        case 0:
                            MessageBox.Show("Nota no válida");
                            break;
                        case 1:
                            MessageBox.Show("Aplazado");
                            break;
                        case 2:
                            MessageBox.Show("Aplazado");
                            break;
                        case 3:
                            MessageBox.Show("Aplazado");
                            break;
                        case 4:
                            MessageBox.Show("Regular");
                            break;
                        case 5:
                            MessageBox.Show("Regular");
                            break;
                        case 6:
                            MessageBox.Show("Aprobado");
                            break;
                        case 7:
                            MessageBox.Show("Promocionado");
                            break;
                        case 8:
                            MessageBox.Show("Aprobado");
                            break;
                        case 9:
                            MessageBox.Show("Aprobado");
                            break;
                        case 10:
                            MessageBox.Show("Felicitaciones !!");
                            break;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("No puede dejar el campo vacio");
                }

                   
            }   
        }
    }
}



                   

