using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_mientras_
{
    public partial class While_Mientras_ : Form
    {
        public While_Mientras_()
        {
            InitializeComponent();
        }

        private void BtDoWhile_Click(object sender, EventArgs e)
        {
            Form DoWhile = new doWhile_HacerMientras_();
            DoWhile.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btacomodar_Click(object sender, EventArgs e)
        {
           while (true)
           {

                lbazul.Left = lbazul.Left + 1;
                lbrojo.Left = lbrojo.Left - 1;

                this.Refresh();

                if ((lbazul.Left + lbrojo.Width) == lbrojo.Left)
                {
                    break;
                }

           }
        }
    }
}
