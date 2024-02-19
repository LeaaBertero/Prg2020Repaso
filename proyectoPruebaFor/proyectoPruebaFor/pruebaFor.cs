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
            //botón arraque que cuenta de 1 hasta 10 a velocidad  
            for (int contador = 0; contador <= 10; contador++)
            {
                lbVerde.Text = contador.ToString();
                this.Refresh();
                lbVerde.BackColor = Color.Pink;
            }          
        }

        
        private void btiniciar_Click(object sender, EventArgs e)
        {
            //primera vuelta izquierda a derecha
            for (int movimiento = 261; movimiento < 1084; movimiento++)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Blue;
                lbVerde.ForeColor = Color.White;
                this.Refresh();
            }

            //segunda vuelta izquierda a centro
            for (int movimiento = 261; movimiento < 678; movimiento++)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Pink;
                lbVerde.ForeColor = Color.White;
                this.Refresh();
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            //primera vuelta izquierda a derecha
            for (int movimiento = 1084; movimiento > 260; movimiento--)
            {
                lbVerde.Left = movimiento;
                lbVerde.BackColor = Color.Gold;
                lbVerde.ForeColor = Color.Black;
                this.Refresh();
            }
            //segunda vuelta derecha a centro
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
              
               



