using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class ProyectoPOO : Form
    {
        Persona PersonaMostrar = new Persona();
        public ProyectoPOO()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {

            //variable PersonaMostrar es igual a lo que el usuario ingrese en los texbox
            PersonaMostrar.Nombre = TxNombre.Text;
            PersonaMostrar.Apellido = TxApellido.Text;

            //lbMostrar.Text = PersonaMostrar.Nombre + " " + PersonaMostrar.Apellido;

            lbMostrar.Text = PersonaMostrar.NombreCompleto();

            //PersonaMostrar = null;
            PersonaMostrar = new Persona();

            TxNombre.Focus();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btInscribir_Click(object sender, EventArgs e)
        {
            //instanciar el objeto
            Materia MateriaInscripta = new Materia();
            
            MateriaInscripta.NombreMateria = txnombreMateria.Text;
            MateriaInscripta.añoMateria = Convert.ToInt32(txañoMateria.Text);

            //PersonaMostrar.MateriaCursando = MateriaInscripta;
            PersonaMostrar.Inscribir(MateriaInscripta);

            //lbInscipcionMateria.Text = PersonaMostrar.MateriaCursando.NombreMateria +
            //    " " + "Año" + " " + PersonaMostrar.MateriaCursando.añoMateria.ToString();

            lbInscipcionMateria.Text = PersonaMostrar.nombreCompletoConMateria();
            
        }
    }
}
