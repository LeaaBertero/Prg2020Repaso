using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPruebaFor
{
    public partial class pruebaFor : Form
    {
        public pruebaFor()
        {
            InitializeComponent();
        }

        private void btarranque_Click(object sender, EventArgs e)
        {

            for (int contador = 0; contador <= 10; contador++)
            {
                lbVerde.Text = contador.ToString();
                this.Refresh();

                lbVerde.BackColor = Color.Pink;
            }
        }
        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            for (int movimiento = 261; movimiento < 1084; movimiento++)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Blue;
                lbVerde.ForeColor = Color.White;
                this.Refresh();
            }

            for (int movimiento = 261; movimiento < 678; movimiento++)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Pink;
                lbVerde.ForeColor = Color.White;
                this.Refresh();
            }
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            for (int movimiento = 1084; movimiento > 260; movimiento--)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Gold;
                lbVerde.ForeColor = Color.Black;
                this.Refresh();
            }

            for (int movimiento = 1084; movimiento > 678; movimiento--)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Turquoise;
                lbVerde.ForeColor = Color.Black;
                this.Refresh();
            }
        }
    }
}
              
               



