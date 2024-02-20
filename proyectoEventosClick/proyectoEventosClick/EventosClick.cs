using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEventosClick
{
    public partial class EventosClick : Form
    {
        public EventosClick()
        {
            InitializeComponent();
        }



        private void btIniciar_MouseMove(object sender, MouseEventArgs e)
        {
            btIniciar.Left = btIniciar.Left + 5;
            //this.Refresh();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btbajar.Top = btbajar.Top + 5;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsubir_MouseMove(object sender, MouseEventArgs e)
        {
            btsubir.Top = btsubir.Top - 5;
        }

        private void btizquierda_MouseMove(object sender, MouseEventArgs e)
        {
            btizquierda.Left = btizquierda.Left - 5;
        }
    }
}
