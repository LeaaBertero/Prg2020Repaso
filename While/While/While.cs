using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class While : Form
    {   
        //constructor
        public While()
        {
            InitializeComponent();
        }

        private void btejecutar_Click(object sender, EventArgs e)
        {
            Form DoWhile = new DoWhile();
            DoWhile.ShowDialog();
            btejecutar.BackColor = Color.Green;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btiniciar_Click(object sender, EventArgs e)
        {
            //declaración de variables 
            //Rectangulo Rojo
            int anchoFormulario;
            int ancholabel;
            int anchoBorde = 50;
            int X;
            int paso = 2;

            //variables inicializadas
            anchoFormulario = this.Width;
            ancholabel = lblRojo.Width;
            X = 0;

            //evento click de botón
            btiniciar.BackColor = Color.HotPink;

            //for (int incremento = 0; incremento < anchoFormulario - ancholabel - anchoBorde; incremento++)
            //{
            //    lblcuadrado.Left = incremento;
            //    this.Refresh();
            //} 

            //estructura de while(Mientras)
            while (X < anchoFormulario - ancholabel - anchoBorde)
            {
                lblRojo.Left = X;
                X = X + paso;
                this.Refresh();
            }
        }
    }
}

               




      
