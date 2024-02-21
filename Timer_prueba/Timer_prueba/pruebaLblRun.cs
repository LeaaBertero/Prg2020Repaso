using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_prueba
{
    public partial class pruebaLblRun : Form
    {
        public pruebaLblRun()
        {
            InitializeComponent();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btrojo_Click(object sender, EventArgs e)
        {

            for (int incrementoRojo = 12; incrementoRojo < 36; incrementoRojo++)
            {
               
                lbrojo.Left = lbrojo.Left + 10;
                this.Refresh();
            }

            MessageBox.Show("Hasta acá llega Rojo");


        }

        private void btverde_Click(object sender, EventArgs e)
        {

            for (int incrementoVerde = 105; incrementoVerde > 72; incrementoVerde--)
            {
                lbverde.Left = lbverde.Left - 10;
                this.Refresh();
            }

            MessageBox.Show("Hasta acá llega Verde");

        }
    }
}
