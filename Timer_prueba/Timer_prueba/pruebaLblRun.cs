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
            if (lbrojo.Left <= 249)
            {
                lbrojo.Left = lbrojo.Left + 10;
                this.Refresh();
                lbrojo.BackColor = Color.Cyan;
            }
            else
            {
                MessageBox.Show("Éste es el limite Rojo");
            }

            

        }

        private void btverde_Click(object sender, EventArgs e)
        {
            if (lbverde.Left >= 450)
            {
                lbverde.Left = lbverde.Left - 10;
                this.Refresh();
                lbverde.BackColor = Color.DeepPink;
               
            }
            else
            {
                MessageBox.Show("Éste es el limite Verde");
            }
            


        }

        private void lbblack_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (lbblack.Left <= 140)
            {
                lbblack.Left = lbblack.Left + 10;
            }
        }

        private void btcomenzar_Click(object sender, EventArgs e)
        {
            lbblack.BackColor = Color.Gold;
        }
    }
}
